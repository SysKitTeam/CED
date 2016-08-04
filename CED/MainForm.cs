using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CED.Properties;
using System.Xml.Linq;

namespace CED
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            SetupForm();
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            if (ValidateFormData(optionCheckBox.Checked))
            {
                errorProviderConfigSection.Clear();
                errorProviderCustomProvider.Clear();
                errorProviderFile.Clear();

                outputTextBox.Text = "";
                var tempDirectoryName = Guid.NewGuid().ToString();

                var configFileName = Path.GetFileName(configFileOpenDialog.FileName);
                var transformFileName = Path.GetFileName(transformFileOpenDialog.FileName);

                Directory.CreateDirectory(tempDirectoryName);

                System.Diagnostics.Process process = new System.Diagnostics.Process();
                System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                startInfo.FileName = "cmd.exe";

                startInfo.RedirectStandardOutput = true;
                startInfo.RedirectStandardError = true;
                startInfo.UseShellExecute = false;
                startInfo.CreateNoWindow = true;

                startInfo.WorkingDirectory = tempDirectoryName;

                Settings.Default.ConfigSectionsHistory = AddToCollection(Settings.Default.ConfigSectionsHistory,
                    configurationSectionTextBox);
                Settings.Default.CustomProvidersHistory = AddToCollection(Settings.Default.CustomProvidersHistory,
                    customProviderTextBox);
                Settings.Default.Save();

                // Working with config transformations
                if (optionCheckBox.Checked)
                {
                    var transformedFilePath = Path.GetFullPath($"{tempDirectoryName}\\web.config");

                    startInfo.Arguments =
                        $"/C {Environment.CurrentDirectory}\\ctt.exe \"source: \"{configFileTextBox.Text}\"\" \"transform: \"{transformFileTextBox.Text}\"\" \"destination: \"{transformedFilePath}\"\"";

                    process.StartInfo = startInfo;
                    process.Start();
                    process.WaitForExit();

                    FormatDocument(tempDirectoryName);
                }
                else
                {
                    File.Copy(configFileOpenDialog.FileName, $"{tempDirectoryName}\\web.config");   
                }

                if (encryptRadioButton.Checked)
                {
                    startInfo.Arguments =
                        $"/C {System.Runtime.InteropServices.RuntimeEnvironment.GetRuntimeDirectory()}\\aspnet_regiis -pef \"{configurationSectionTextBox.Text}\" \".\" -prov \"{customProviderTextBox.Text}\"";
                }
                else
                {
                    startInfo.Arguments =
                        $"/C {System.Runtime.InteropServices.RuntimeEnvironment.GetRuntimeDirectory()}\\aspnet_regiis -pdf \"{configurationSectionTextBox.Text}\" \".\"";
                }

                process.StartInfo = startInfo;
                process.Start();

                var output = process.StandardOutput.ReadToEnd();
                process.WaitForExit();

                // this works with English Windows, it might be different for a different localization
                if (output.EndsWith("Succeeded!\r\n"))
                {
                    outputTextBox.Text = System.IO.File.ReadAllText($"{tempDirectoryName}\\web.config");
                }
                else
                {
                    outputTextBox.Text = output;
                }

                try
                {
                    Directory.Delete($"{tempDirectoryName}", true);
                }
                catch (Exception)
                {
                    // cannot delete temp folder, ignore
                }
            }
            else
            {
                MessageBox.Show("All the fields are required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void attachConfigButton_Click(object sender, EventArgs e)
        {
            DialogResult result = configFileOpenDialog.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                configFileTextBox.Text = configFileOpenDialog.FileName;
            }

            ValidateConfigFile();
        }

        private void attachButtonTransform_Click(object sender, EventArgs e)
        {
            DialogResult result = transformFileOpenDialog.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                transformFileTextBox.Text = transformFileOpenDialog.FileName;
            }

            ValidateTransformFile();
        }

        private StringCollection AddToCollection(StringCollection collection, TextBox textBox)
        {
            if (collection == null)
            {
                collection = new StringCollection();
            }

            if (!string.IsNullOrEmpty(textBox.Text) && !collection.Contains(textBox.Text))
            {
                collection.Add(textBox.Text);
                AutoCompleteConfigure(textBox, collection);
                
            }

            return collection;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            AutoCompleteConfigure(configurationSectionTextBox, Settings.Default.ConfigSectionsHistory);
            configurationSectionTextBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            configurationSectionTextBox.AutoCompleteSource = AutoCompleteSource.CustomSource;

            AutoCompleteConfigure(customProviderTextBox, Settings.Default.CustomProvidersHistory);
            customProviderTextBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            customProviderTextBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void AutoCompleteConfigure(TextBox textBox, StringCollection stringCollection)
        {
            if (stringCollection!=null && stringCollection.Count > 0)
            {
                string[] strArray = new string[stringCollection.Count];
                stringCollection.CopyTo(strArray, 0);

                AutoCompleteStringCollection list = new AutoCompleteStringCollection();
                list.AddRange(strArray);

                textBox.AutoCompleteCustomSource = list;
            }
        }

        private void configurationSectionTextBox_Validating(object sender, CancelEventArgs e)
        {
            ValidateConfigurationSection();
        }

        private bool ValidateConfigurationSection()
        {
            if (string.IsNullOrEmpty(configurationSectionTextBox.Text))
            {
                errorProviderCustomProvider.SetError(configurationSectionTextBox, "Please enter Configuration Section name.");
                return false;
            }

            return true;
        }

        private bool ValidateCustomProvider()
        {
            if (string.IsNullOrEmpty(customProviderTextBox.Text) && customProviderTextBox.Enabled)
            {
                errorProviderCustomProvider.SetError(customProviderTextBox, "Please enter Configuration Section name.");
                return false;
            }

            return true;
        }

        private bool ValidateFormData(bool boxChecked)
        {
            var customProviderStatus = ValidateCustomProvider();
            var configFileStatus = ValidateConfigFile();
            if (boxChecked)
            {
                configFileStatus &= ValidateTransformFile();
            }
            var configurationStatus = ValidateConfigurationSection();

            return customProviderStatus && configFileStatus && configurationStatus;
        }

        private bool ValidateConfigFile()
        {
            if (string.IsNullOrEmpty(configFileTextBox.Text))
            {
                errorProviderFile.SetError(configFileTextBox, "Please select a input file.");
                return false;
            }

            return true;
        }

        private bool ValidateTransformFile()
        {
            if (string.IsNullOrEmpty(transformFileTextBox.Text))
            {
                errorProviderFile.SetError(transformFileTextBox, "Please select a input file.");
                return false;
            }
            return true;
        }


        private void attachButtonConfig_Validating(object sender, CancelEventArgs e)
        {
            ValidateConfigFile();
        }

        private void attachButtonTransform_Validating(object sender, CancelEventArgs e)
        {
            ValidateTransformFile();
        }

        private void customProviderTextBox_Validating(object sender, CancelEventArgs e)
        {
            ValidateCustomProvider();
        }

        private void encryptRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            customProviderTextBox.Enabled = encryptRadioButton.Checked;
        }

        private void copyPictureBox_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(outputTextBox.Text);
            }
            catch (System.ArgumentNullException)
            {
                
            }
        }

        private void copyPictureBox_MouseHover(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(this.copyPictureBox, "Copy");
        }

        private void documentationLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/Acceleratio/CED");
        }

        private void configurationSectionTextBox_MouseHover(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(this.configurationSectionTextBox, "e.g. \"connectionStrings\" or \"system.webServer/Security\".");
        }

        private void customProviderTextBox_MouseHover(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(this.customProviderTextBox, "The name of your custom provider, must be referenced from the .config file.");
        }

        private void FormatDocument(string tempDirectoryName)
        {
            string data = System.IO.File.ReadAllText($"{tempDirectoryName}\\web.config");
            var doc = XDocument.Parse(data);
            doc.Save($"{tempDirectoryName}\\web.config");
        }

        private void optionCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            SetupForm();
        }

        private void SetupForm()
        {
            transformFileTextBox.Enabled = optionCheckBox.Checked;
            attachButtonTransform.Enabled = optionCheckBox.Checked;
        }
    }
}
