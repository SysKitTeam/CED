namespace CED
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.configFileOpenDialog = new System.Windows.Forms.OpenFileDialog();
            this.fileLabel = new System.Windows.Forms.Label();
            this.introLabel = new System.Windows.Forms.Label();
            this.fileTextBox = new System.Windows.Forms.TextBox();
            this.attachButton = new System.Windows.Forms.Button();
            this.configSectionLabel = new System.Windows.Forms.Label();
            this.configurationSectionTextBox = new System.Windows.Forms.TextBox();
            this.providerLabel = new System.Windows.Forms.Label();
            this.customProviderTextBox = new System.Windows.Forms.TextBox();
            this.operationLabel = new System.Windows.Forms.Label();
            this.saveToLabel = new System.Windows.Forms.Label();
            this.encryptRadioButton = new System.Windows.Forms.RadioButton();
            this.operationPanel = new System.Windows.Forms.Panel();
            this.decryptRadioButton = new System.Windows.Forms.RadioButton();
            this.saveToPanel = new System.Windows.Forms.Panel();
            this.outputBoxRadioButton = new System.Windows.Forms.RadioButton();
            this.saveToFileRadioButton = new System.Windows.Forms.RadioButton();
            this.runButton = new System.Windows.Forms.Button();
            this.horizontalLabel = new System.Windows.Forms.Label();
            this.outputTextBox = new System.Windows.Forms.RichTextBox();
            this.errorProviderFile = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderConfigSection = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderCustomProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.copyPictureBox = new System.Windows.Forms.PictureBox();
            this.documentationLinkLabel = new System.Windows.Forms.LinkLabel();
            this.asteriskLabel2 = new System.Windows.Forms.Label();
            this.asteriskLabel1 = new System.Windows.Forms.Label();
            this.asteriskFileLabel = new System.Windows.Forms.Label();
            this.operationPanel.SuspendLayout();
            this.saveToPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderConfigSection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCustomProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.copyPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // configFileOpenDialog
            // 
            this.configFileOpenDialog.Filter = "Config Files (*.config) | *.config";
            // 
            // fileLabel
            // 
            this.fileLabel.AutoSize = true;
            this.fileLabel.Location = new System.Drawing.Point(27, 52);
            this.fileLabel.Name = "fileLabel";
            this.fileLabel.Size = new System.Drawing.Size(26, 13);
            this.fileLabel.TabIndex = 0;
            this.fileLabel.Text = "File:";
            // 
            // introLabel
            // 
            this.introLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.introLabel.Location = new System.Drawing.Point(0, 0);
            this.introLabel.Name = "introLabel";
            this.introLabel.Padding = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.introLabel.Size = new System.Drawing.Size(1008, 46);
            this.introLabel.TabIndex = 1;
            this.introLabel.Text = resources.GetString("introLabel.Text");
            // 
            // fileTextBox
            // 
            this.fileTextBox.Location = new System.Drawing.Point(158, 49);
            this.fileTextBox.Name = "fileTextBox";
            this.fileTextBox.ReadOnly = true;
            this.fileTextBox.Size = new System.Drawing.Size(704, 20);
            this.fileTextBox.TabIndex = 2;
            // 
            // attachButton
            // 
            this.attachButton.Location = new System.Drawing.Point(894, 47);
            this.attachButton.Name = "attachButton";
            this.attachButton.Size = new System.Drawing.Size(69, 23);
            this.attachButton.TabIndex = 3;
            this.attachButton.Text = "Attach";
            this.attachButton.UseVisualStyleBackColor = true;
            this.attachButton.Click += new System.EventHandler(this.attachButton_Click);
            this.attachButton.Validating += new System.ComponentModel.CancelEventHandler(this.attachButton_Validating);
            // 
            // configSectionLabel
            // 
            this.configSectionLabel.AutoSize = true;
            this.configSectionLabel.Location = new System.Drawing.Point(27, 80);
            this.configSectionLabel.Name = "configSectionLabel";
            this.configSectionLabel.Size = new System.Drawing.Size(111, 13);
            this.configSectionLabel.TabIndex = 4;
            this.configSectionLabel.Text = "Configuration Section:";
            // 
            // configurationSectionTextBox
            // 
            this.configurationSectionTextBox.Location = new System.Drawing.Point(158, 79);
            this.configurationSectionTextBox.Name = "configurationSectionTextBox";
            this.configurationSectionTextBox.Size = new System.Drawing.Size(300, 20);
            this.configurationSectionTextBox.TabIndex = 5;
            this.configurationSectionTextBox.MouseHover += new System.EventHandler(this.configurationSectionTextBox_MouseHover);
            this.configurationSectionTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.configurationSectionTextBox_Validating);
            // 
            // providerLabel
            // 
            this.providerLabel.AutoSize = true;
            this.providerLabel.Location = new System.Drawing.Point(491, 80);
            this.providerLabel.Name = "providerLabel";
            this.providerLabel.Size = new System.Drawing.Size(49, 13);
            this.providerLabel.TabIndex = 6;
            this.providerLabel.Text = "Provider:";
            // 
            // customProviderTextBox
            // 
            this.customProviderTextBox.Location = new System.Drawing.Point(562, 77);
            this.customProviderTextBox.Name = "customProviderTextBox";
            this.customProviderTextBox.Size = new System.Drawing.Size(300, 20);
            this.customProviderTextBox.TabIndex = 7;
            this.customProviderTextBox.MouseHover += new System.EventHandler(this.customProviderTextBox_MouseHover);
            this.customProviderTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.customProviderTextBox_Validating);
            // 
            // operationLabel
            // 
            this.operationLabel.AutoSize = true;
            this.operationLabel.Location = new System.Drawing.Point(27, 114);
            this.operationLabel.Name = "operationLabel";
            this.operationLabel.Size = new System.Drawing.Size(56, 13);
            this.operationLabel.TabIndex = 8;
            this.operationLabel.Text = "Operation:";
            // 
            // saveToLabel
            // 
            this.saveToLabel.AutoSize = true;
            this.saveToLabel.Location = new System.Drawing.Point(491, 114);
            this.saveToLabel.Name = "saveToLabel";
            this.saveToLabel.Size = new System.Drawing.Size(51, 13);
            this.saveToLabel.TabIndex = 9;
            this.saveToLabel.Text = "Save To:";
            // 
            // encryptRadioButton
            // 
            this.encryptRadioButton.AutoSize = true;
            this.encryptRadioButton.Checked = true;
            this.encryptRadioButton.Location = new System.Drawing.Point(3, 3);
            this.encryptRadioButton.Name = "encryptRadioButton";
            this.encryptRadioButton.Size = new System.Drawing.Size(61, 17);
            this.encryptRadioButton.TabIndex = 10;
            this.encryptRadioButton.TabStop = true;
            this.encryptRadioButton.Text = "Encrypt";
            this.encryptRadioButton.UseMnemonic = false;
            this.encryptRadioButton.UseVisualStyleBackColor = true;
            this.encryptRadioButton.CheckedChanged += new System.EventHandler(this.encryptRadioButton_CheckedChanged);
            // 
            // operationPanel
            // 
            this.operationPanel.Controls.Add(this.decryptRadioButton);
            this.operationPanel.Controls.Add(this.encryptRadioButton);
            this.operationPanel.Location = new System.Drawing.Point(158, 109);
            this.operationPanel.Name = "operationPanel";
            this.operationPanel.Size = new System.Drawing.Size(300, 26);
            this.operationPanel.TabIndex = 11;
            // 
            // decryptRadioButton
            // 
            this.decryptRadioButton.AutoSize = true;
            this.decryptRadioButton.Location = new System.Drawing.Point(79, 3);
            this.decryptRadioButton.Name = "decryptRadioButton";
            this.decryptRadioButton.Size = new System.Drawing.Size(62, 17);
            this.decryptRadioButton.TabIndex = 11;
            this.decryptRadioButton.Text = "Decrypt";
            this.decryptRadioButton.UseMnemonic = false;
            this.decryptRadioButton.UseVisualStyleBackColor = true;
            // 
            // saveToPanel
            // 
            this.saveToPanel.Controls.Add(this.outputBoxRadioButton);
            this.saveToPanel.Controls.Add(this.saveToFileRadioButton);
            this.saveToPanel.Location = new System.Drawing.Point(562, 109);
            this.saveToPanel.Name = "saveToPanel";
            this.saveToPanel.Size = new System.Drawing.Size(300, 26);
            this.saveToPanel.TabIndex = 12;
            // 
            // outputBoxRadioButton
            // 
            this.outputBoxRadioButton.AutoSize = true;
            this.outputBoxRadioButton.Checked = true;
            this.outputBoxRadioButton.Location = new System.Drawing.Point(90, 3);
            this.outputBoxRadioButton.Name = "outputBoxRadioButton";
            this.outputBoxRadioButton.Size = new System.Drawing.Size(99, 17);
            this.outputBoxRadioButton.TabIndex = 11;
            this.outputBoxRadioButton.TabStop = true;
            this.outputBoxRadioButton.Text = "Output Window";
            this.outputBoxRadioButton.UseMnemonic = false;
            this.outputBoxRadioButton.UseVisualStyleBackColor = true;
            // 
            // saveToFileRadioButton
            // 
            this.saveToFileRadioButton.AutoSize = true;
            this.saveToFileRadioButton.Enabled = false;
            this.saveToFileRadioButton.Location = new System.Drawing.Point(3, 3);
            this.saveToFileRadioButton.Name = "saveToFileRadioButton";
            this.saveToFileRadioButton.Size = new System.Drawing.Size(81, 17);
            this.saveToFileRadioButton.TabIndex = 10;
            this.saveToFileRadioButton.Text = "Save to File";
            this.saveToFileRadioButton.UseMnemonic = false;
            this.saveToFileRadioButton.UseVisualStyleBackColor = true;
            // 
            // runButton
            // 
            this.runButton.Location = new System.Drawing.Point(158, 151);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(75, 23);
            this.runButton.TabIndex = 13;
            this.runButton.Text = "Run";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // horizontalLabel
            // 
            this.horizontalLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.horizontalLabel.Location = new System.Drawing.Point(26, 183);
            this.horizontalLabel.Name = "horizontalLabel";
            this.horizontalLabel.Size = new System.Drawing.Size(937, 1);
            this.horizontalLabel.TabIndex = 14;
            // 
            // outputTextBox
            // 
            this.outputTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputTextBox.Location = new System.Drawing.Point(30, 209);
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.ReadOnly = true;
            this.outputTextBox.Size = new System.Drawing.Size(933, 508);
            this.outputTextBox.TabIndex = 15;
            this.outputTextBox.Text = "";
            // 
            // errorProviderFile
            // 
            this.errorProviderFile.ContainerControl = this;
            // 
            // errorProviderConfigSection
            // 
            this.errorProviderConfigSection.ContainerControl = this;
            // 
            // errorProviderCustomProvider
            // 
            this.errorProviderCustomProvider.ContainerControl = this;
            // 
            // copyPictureBox
            // 
            this.copyPictureBox.Image = global::CED.Properties.Resources.Copy;
            this.copyPictureBox.Location = new System.Drawing.Point(943, 187);
            this.copyPictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.copyPictureBox.Name = "copyPictureBox";
            this.copyPictureBox.Size = new System.Drawing.Size(16, 16);
            this.copyPictureBox.TabIndex = 16;
            this.copyPictureBox.TabStop = false;
            this.copyPictureBox.Click += new System.EventHandler(this.copyPictureBox_Click);
            this.copyPictureBox.MouseHover += new System.EventHandler(this.copyPictureBox_MouseHover);
            // 
            // documentationLinkLabel
            // 
            this.documentationLinkLabel.AutoSize = true;
            this.documentationLinkLabel.Location = new System.Drawing.Point(223, 19);
            this.documentationLinkLabel.Name = "documentationLinkLabel";
            this.documentationLinkLabel.Size = new System.Drawing.Size(88, 13);
            this.documentationLinkLabel.TabIndex = 17;
            this.documentationLinkLabel.TabStop = true;
            this.documentationLinkLabel.Text = "Documentation...";
            this.documentationLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.documentationLinkLabel_LinkClicked);
            // 
            // asteriskLabel2
            // 
            this.asteriskLabel2.AutoSize = true;
            this.asteriskLabel2.BackColor = System.Drawing.Color.Transparent;
            this.asteriskLabel2.ForeColor = System.Drawing.Color.Red;
            this.asteriskLabel2.Location = new System.Drawing.Point(538, 79);
            this.asteriskLabel2.Name = "asteriskLabel2";
            this.asteriskLabel2.Size = new System.Drawing.Size(11, 13);
            this.asteriskLabel2.TabIndex = 18;
            this.asteriskLabel2.Text = "*";
            // 
            // asteriskLabel1
            // 
            this.asteriskLabel1.AutoSize = true;
            this.asteriskLabel1.BackColor = System.Drawing.Color.Transparent;
            this.asteriskLabel1.ForeColor = System.Drawing.Color.Red;
            this.asteriskLabel1.Location = new System.Drawing.Point(136, 80);
            this.asteriskLabel1.Name = "asteriskLabel1";
            this.asteriskLabel1.Size = new System.Drawing.Size(11, 13);
            this.asteriskLabel1.TabIndex = 19;
            this.asteriskLabel1.Text = "*";
            // 
            // asteriskFileLabel
            // 
            this.asteriskFileLabel.AutoSize = true;
            this.asteriskFileLabel.BackColor = System.Drawing.Color.Transparent;
            this.asteriskFileLabel.ForeColor = System.Drawing.Color.Red;
            this.asteriskFileLabel.Location = new System.Drawing.Point(52, 52);
            this.asteriskFileLabel.Name = "asteriskFileLabel";
            this.asteriskFileLabel.Size = new System.Drawing.Size(11, 13);
            this.asteriskFileLabel.TabIndex = 20;
            this.asteriskFileLabel.Text = "*";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.asteriskFileLabel);
            this.Controls.Add(this.asteriskLabel1);
            this.Controls.Add(this.asteriskLabel2);
            this.Controls.Add(this.documentationLinkLabel);
            this.Controls.Add(this.copyPictureBox);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.horizontalLabel);
            this.Controls.Add(this.runButton);
            this.Controls.Add(this.saveToPanel);
            this.Controls.Add(this.operationPanel);
            this.Controls.Add(this.saveToLabel);
            this.Controls.Add(this.operationLabel);
            this.Controls.Add(this.customProviderTextBox);
            this.Controls.Add(this.providerLabel);
            this.Controls.Add(this.configurationSectionTextBox);
            this.Controls.Add(this.configSectionLabel);
            this.Controls.Add(this.attachButton);
            this.Controls.Add(this.fileTextBox);
            this.Controls.Add(this.introLabel);
            this.Controls.Add(this.fileLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1024, 768);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CED - .config Encrypt & Decrypt";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.operationPanel.ResumeLayout(false);
            this.operationPanel.PerformLayout();
            this.saveToPanel.ResumeLayout(false);
            this.saveToPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderConfigSection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCustomProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.copyPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog configFileOpenDialog;
        private System.Windows.Forms.Label fileLabel;
        private System.Windows.Forms.Label introLabel;
        private System.Windows.Forms.TextBox fileTextBox;
        private System.Windows.Forms.Button attachButton;
        private System.Windows.Forms.Label configSectionLabel;
        private System.Windows.Forms.TextBox configurationSectionTextBox;
        private System.Windows.Forms.Label providerLabel;
        private System.Windows.Forms.TextBox customProviderTextBox;
        private System.Windows.Forms.Label operationLabel;
        private System.Windows.Forms.Label saveToLabel;
        private System.Windows.Forms.RadioButton encryptRadioButton;
        private System.Windows.Forms.Panel operationPanel;
        private System.Windows.Forms.RadioButton decryptRadioButton;
        private System.Windows.Forms.Panel saveToPanel;
        private System.Windows.Forms.RadioButton outputBoxRadioButton;
        private System.Windows.Forms.RadioButton saveToFileRadioButton;
        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.Label horizontalLabel;
        private System.Windows.Forms.RichTextBox outputTextBox;
        private System.Windows.Forms.ErrorProvider errorProviderFile;
        private System.Windows.Forms.ErrorProvider errorProviderConfigSection;
        private System.Windows.Forms.ErrorProvider errorProviderCustomProvider;
        private System.Windows.Forms.PictureBox copyPictureBox;
        private System.Windows.Forms.LinkLabel documentationLinkLabel;
        private System.Windows.Forms.Label asteriskLabel1;
        private System.Windows.Forms.Label asteriskLabel2;
        private System.Windows.Forms.Label asteriskFileLabel;
    }
}

