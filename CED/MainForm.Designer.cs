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
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.outputBoxRadioButton = new System.Windows.Forms.RadioButton();
            this.saveToFileRadioButton = new System.Windows.Forms.RadioButton();
            this.runButton = new System.Windows.Forms.Button();
            this.horizontalLabel = new System.Windows.Forms.Label();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // configFileOpenDialog
            // 
            this.configFileOpenDialog.Filter = "Config Files (*.config) | *.config";
            // 
            // fileLabel
            // 
            this.fileLabel.AutoSize = true;
            this.fileLabel.Location = new System.Drawing.Point(12, 52);
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
            this.introLabel.Size = new System.Drawing.Size(617, 46);
            this.introLabel.TabIndex = 1;
            this.introLabel.Text = resources.GetString("introLabel.Text");
            // 
            // fileTextBox
            // 
            this.fileTextBox.Location = new System.Drawing.Point(143, 49);
            this.fileTextBox.Name = "fileTextBox";
            this.fileTextBox.ReadOnly = true;
            this.fileTextBox.Size = new System.Drawing.Size(380, 20);
            this.fileTextBox.TabIndex = 2;
            // 
            // attachButton
            // 
            this.attachButton.Location = new System.Drawing.Point(529, 47);
            this.attachButton.Name = "attachButton";
            this.attachButton.Size = new System.Drawing.Size(75, 23);
            this.attachButton.TabIndex = 3;
            this.attachButton.Text = "Attach";
            this.attachButton.UseVisualStyleBackColor = true;
            this.attachButton.Click += new System.EventHandler(this.attachButton_Click);
            // 
            // configSectionLabel
            // 
            this.configSectionLabel.AutoSize = true;
            this.configSectionLabel.Location = new System.Drawing.Point(12, 80);
            this.configSectionLabel.Name = "configSectionLabel";
            this.configSectionLabel.Size = new System.Drawing.Size(111, 13);
            this.configSectionLabel.TabIndex = 4;
            this.configSectionLabel.Text = "Configuration Section:";
            // 
            // configurationSectionTextBox
            // 
            this.configurationSectionTextBox.Location = new System.Drawing.Point(143, 79);
            this.configurationSectionTextBox.Name = "configurationSectionTextBox";
            this.configurationSectionTextBox.Size = new System.Drawing.Size(461, 20);
            this.configurationSectionTextBox.TabIndex = 5;
            // 
            // providerLabel
            // 
            this.providerLabel.AutoSize = true;
            this.providerLabel.Location = new System.Drawing.Point(12, 112);
            this.providerLabel.Name = "providerLabel";
            this.providerLabel.Size = new System.Drawing.Size(49, 13);
            this.providerLabel.TabIndex = 6;
            this.providerLabel.Text = "Provider:";
            // 
            // providerTextBox
            // 
            this.customProviderTextBox.Location = new System.Drawing.Point(143, 109);
            this.customProviderTextBox.Name = "customProviderTextBox";
            this.customProviderTextBox.Size = new System.Drawing.Size(461, 20);
            this.customProviderTextBox.TabIndex = 7;
            // 
            // operationLabel
            // 
            this.operationLabel.AutoSize = true;
            this.operationLabel.Location = new System.Drawing.Point(12, 140);
            this.operationLabel.Name = "operationLabel";
            this.operationLabel.Size = new System.Drawing.Size(56, 13);
            this.operationLabel.TabIndex = 8;
            this.operationLabel.Text = "Operation:";
            // 
            // saveToLabel
            // 
            this.saveToLabel.AutoSize = true;
            this.saveToLabel.Location = new System.Drawing.Point(12, 172);
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
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.encryptRadioButton);
            this.panel1.Location = new System.Drawing.Point(143, 135);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(461, 26);
            this.panel1.TabIndex = 11;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(79, 3);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(62, 17);
            this.radioButton1.TabIndex = 11;
            this.radioButton1.Text = "Decrypt";
            this.radioButton1.UseMnemonic = false;
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.outputBoxRadioButton);
            this.panel2.Controls.Add(this.saveToFileRadioButton);
            this.panel2.Location = new System.Drawing.Point(143, 167);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(461, 26);
            this.panel2.TabIndex = 12;
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
            this.runButton.Location = new System.Drawing.Point(143, 200);
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
            this.horizontalLabel.Location = new System.Drawing.Point(9, 230);
            this.horizontalLabel.Name = "horizontalLabel";
            this.horizontalLabel.Size = new System.Drawing.Size(593, 1);
            this.horizontalLabel.TabIndex = 14;
            // 
            // outputTextBox
            // 
            this.outputTextBox.Location = new System.Drawing.Point(9, 234);
            this.outputTextBox.Multiline = true;
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.ReadOnly = true;
            this.outputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.outputTextBox.Size = new System.Drawing.Size(593, 238);
            this.outputTextBox.TabIndex = 15;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 481);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.horizontalLabel);
            this.Controls.Add(this.runButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
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
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(633, 520);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(633, 520);
            this.Name = "MainForm";
            this.Text = "CED - .config Encrypt & Decrypt";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton outputBoxRadioButton;
        private System.Windows.Forms.RadioButton saveToFileRadioButton;
        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.Label horizontalLabel;
        private System.Windows.Forms.TextBox outputTextBox;
    }
}

