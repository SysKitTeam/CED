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
            this.configFileLabel = new System.Windows.Forms.Label();
            this.introLabel = new System.Windows.Forms.Label();
            this.configFileTextBox = new System.Windows.Forms.TextBox();
            this.attachButtonConfig = new System.Windows.Forms.Button();
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
            this.asteriskProviderLabel = new System.Windows.Forms.Label();
            this.asteriskConfSectionLabel = new System.Windows.Forms.Label();
            this.asteriskConfigLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.asterikTransformLabel = new System.Windows.Forms.Label();
            this.transformFileTextBox = new System.Windows.Forms.TextBox();
            this.attachButtonTransform = new System.Windows.Forms.Button();
            this.transformFileOpenDialog = new System.Windows.Forms.OpenFileDialog();
            this.optionCheckBox = new System.Windows.Forms.CheckBox();
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
            // configFileLabel
            // 
            this.configFileLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.configFileLabel.AutoSize = true;
            this.configFileLabel.Location = new System.Drawing.Point(27, 71);
            this.configFileLabel.Name = "configFileLabel";
            this.configFileLabel.Size = new System.Drawing.Size(56, 13);
            this.configFileLabel.TabIndex = 0;
            this.configFileLabel.Text = "Config file:";
            // 
            // introLabel
            // 
            this.introLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.introLabel.Location = new System.Drawing.Point(0, 0);
            this.introLabel.Name = "introLabel";
            this.introLabel.Padding = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.introLabel.Size = new System.Drawing.Size(1004, 46);
            this.introLabel.TabIndex = 1;
            this.introLabel.Text = resources.GetString("introLabel.Text");
            // 
            // configFileTextBox
            // 
            this.configFileTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.configFileTextBox.Location = new System.Drawing.Point(158, 68);
            this.configFileTextBox.Name = "configFileTextBox";
            this.configFileTextBox.ReadOnly = true;
            this.configFileTextBox.Size = new System.Drawing.Size(704, 20);
            this.configFileTextBox.TabIndex = 2;
            // 
            // attachButtonConfig
            // 
            this.attachButtonConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.attachButtonConfig.Location = new System.Drawing.Point(894, 66);
            this.attachButtonConfig.Name = "attachButtonConfig";
            this.attachButtonConfig.Size = new System.Drawing.Size(95, 23);
            this.attachButtonConfig.TabIndex = 3;
            this.attachButtonConfig.Text = "Attach config";
            this.attachButtonConfig.UseVisualStyleBackColor = true;
            this.attachButtonConfig.Click += new System.EventHandler(this.attachConfigButton_Click);
            this.attachButtonConfig.Validating += new System.ComponentModel.CancelEventHandler(this.attachButtonConfig_Validating);
            // 
            // configSectionLabel
            // 
            this.configSectionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.configSectionLabel.AutoSize = true;
            this.configSectionLabel.Location = new System.Drawing.Point(27, 135);
            this.configSectionLabel.Name = "configSectionLabel";
            this.configSectionLabel.Size = new System.Drawing.Size(111, 13);
            this.configSectionLabel.TabIndex = 4;
            this.configSectionLabel.Text = "Configuration Section:";
            // 
            // configurationSectionTextBox
            // 
            this.configurationSectionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.configurationSectionTextBox.Location = new System.Drawing.Point(158, 132);
            this.configurationSectionTextBox.Name = "configurationSectionTextBox";
            this.configurationSectionTextBox.Size = new System.Drawing.Size(300, 20);
            this.configurationSectionTextBox.TabIndex = 5;
            this.configurationSectionTextBox.MouseHover += new System.EventHandler(this.configurationSectionTextBox_MouseHover);
            this.configurationSectionTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.configurationSectionTextBox_Validating);
            // 
            // providerLabel
            // 
            this.providerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.providerLabel.AutoSize = true;
            this.providerLabel.Location = new System.Drawing.Point(491, 135);
            this.providerLabel.Name = "providerLabel";
            this.providerLabel.Size = new System.Drawing.Size(49, 13);
            this.providerLabel.TabIndex = 6;
            this.providerLabel.Text = "Provider:";
            // 
            // customProviderTextBox
            // 
            this.customProviderTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customProviderTextBox.Location = new System.Drawing.Point(562, 132);
            this.customProviderTextBox.Name = "customProviderTextBox";
            this.customProviderTextBox.Size = new System.Drawing.Size(300, 20);
            this.customProviderTextBox.TabIndex = 7;
            this.customProviderTextBox.MouseHover += new System.EventHandler(this.customProviderTextBox_MouseHover);
            this.customProviderTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.customProviderTextBox_Validating);
            // 
            // operationLabel
            // 
            this.operationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.operationLabel.AutoSize = true;
            this.operationLabel.Location = new System.Drawing.Point(27, 170);
            this.operationLabel.Name = "operationLabel";
            this.operationLabel.Size = new System.Drawing.Size(56, 13);
            this.operationLabel.TabIndex = 8;
            this.operationLabel.Text = "Operation:";
            // 
            // saveToLabel
            // 
            this.saveToLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.saveToLabel.AutoSize = true;
            this.saveToLabel.Location = new System.Drawing.Point(491, 170);
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
            this.operationPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.operationPanel.Controls.Add(this.decryptRadioButton);
            this.operationPanel.Controls.Add(this.encryptRadioButton);
            this.operationPanel.Location = new System.Drawing.Point(158, 165);
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
            this.saveToPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.saveToPanel.Controls.Add(this.outputBoxRadioButton);
            this.saveToPanel.Controls.Add(this.saveToFileRadioButton);
            this.saveToPanel.Location = new System.Drawing.Point(562, 165);
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
            this.runButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.runButton.Location = new System.Drawing.Point(158, 197);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(75, 23);
            this.runButton.TabIndex = 13;
            this.runButton.Text = "Run";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // horizontalLabel
            // 
            this.horizontalLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.horizontalLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.horizontalLabel.Location = new System.Drawing.Point(32, 226);
            this.horizontalLabel.Name = "horizontalLabel";
            this.horizontalLabel.Size = new System.Drawing.Size(957, 2);
            this.horizontalLabel.TabIndex = 14;
            // 
            // outputTextBox
            // 
            this.outputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputTextBox.Location = new System.Drawing.Point(30, 250);
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.ReadOnly = true;
            this.outputTextBox.Size = new System.Drawing.Size(959, 425);
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
            this.copyPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.copyPictureBox.Image = global::CED.Properties.Resources.Copy;
            this.copyPictureBox.Location = new System.Drawing.Point(973, 231);
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
            // asteriskProviderLabel
            // 
            this.asteriskProviderLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.asteriskProviderLabel.AutoSize = true;
            this.asteriskProviderLabel.BackColor = System.Drawing.Color.Transparent;
            this.asteriskProviderLabel.ForeColor = System.Drawing.Color.Red;
            this.asteriskProviderLabel.Location = new System.Drawing.Point(545, 132);
            this.asteriskProviderLabel.Name = "asteriskProviderLabel";
            this.asteriskProviderLabel.Size = new System.Drawing.Size(11, 13);
            this.asteriskProviderLabel.TabIndex = 18;
            this.asteriskProviderLabel.Text = "*";
            // 
            // asteriskConfSectionLabel
            // 
            this.asteriskConfSectionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.asteriskConfSectionLabel.AutoSize = true;
            this.asteriskConfSectionLabel.BackColor = System.Drawing.Color.Transparent;
            this.asteriskConfSectionLabel.ForeColor = System.Drawing.Color.Red;
            this.asteriskConfSectionLabel.Location = new System.Drawing.Point(141, 132);
            this.asteriskConfSectionLabel.Name = "asteriskConfSectionLabel";
            this.asteriskConfSectionLabel.Size = new System.Drawing.Size(11, 13);
            this.asteriskConfSectionLabel.TabIndex = 19;
            this.asteriskConfSectionLabel.Text = "*";
            // 
            // asteriskConfigLabel
            // 
            this.asteriskConfigLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.asteriskConfigLabel.AutoSize = true;
            this.asteriskConfigLabel.BackColor = System.Drawing.Color.Transparent;
            this.asteriskConfigLabel.ForeColor = System.Drawing.Color.Red;
            this.asteriskConfigLabel.Location = new System.Drawing.Point(89, 68);
            this.asteriskConfigLabel.Name = "asteriskConfigLabel";
            this.asteriskConfigLabel.Size = new System.Drawing.Size(11, 13);
            this.asteriskConfigLabel.TabIndex = 20;
            this.asteriskConfigLabel.Text = "*";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Transform file:";
            // 
            // asterikTransformLabel
            // 
            this.asterikTransformLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.asterikTransformLabel.AutoSize = true;
            this.asterikTransformLabel.BackColor = System.Drawing.Color.Transparent;
            this.asterikTransformLabel.ForeColor = System.Drawing.Color.Red;
            this.asterikTransformLabel.Location = new System.Drawing.Point(106, 100);
            this.asterikTransformLabel.Name = "asterikTransformLabel";
            this.asterikTransformLabel.Size = new System.Drawing.Size(11, 13);
            this.asterikTransformLabel.TabIndex = 22;
            this.asterikTransformLabel.Text = "*";
            // 
            // transformFileTextBox
            // 
            this.transformFileTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.transformFileTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.transformFileTextBox.Location = new System.Drawing.Point(158, 100);
            this.transformFileTextBox.Name = "transformFileTextBox";
            this.transformFileTextBox.Size = new System.Drawing.Size(704, 20);
            this.transformFileTextBox.TabIndex = 23;
            // 
            // attachButtonTransform
            // 
            this.attachButtonTransform.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.attachButtonTransform.Location = new System.Drawing.Point(894, 98);
            this.attachButtonTransform.Name = "attachButtonTransform";
            this.attachButtonTransform.Size = new System.Drawing.Size(95, 23);
            this.attachButtonTransform.TabIndex = 24;
            this.attachButtonTransform.Text = "Attach transform";
            this.attachButtonTransform.UseVisualStyleBackColor = true;
            this.attachButtonTransform.Click += new System.EventHandler(this.attachButtonTransform_Click);
            this.attachButtonTransform.Validating += new System.ComponentModel.CancelEventHandler(this.attachButtonTransform_Validating);
            // 
            // optionCheckBox
            // 
            this.optionCheckBox.AutoSize = true;
            this.optionCheckBox.Location = new System.Drawing.Point(30, 41);
            this.optionCheckBox.Name = "optionCheckBox";
            this.optionCheckBox.Size = new System.Drawing.Size(151, 17);
            this.optionCheckBox.TabIndex = 25;
            this.optionCheckBox.Text = "Use Config Transformation";
            this.optionCheckBox.UseVisualStyleBackColor = true;
            this.optionCheckBox.CheckedChanged += new System.EventHandler(this.optionCheckBox_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1008, 687);
            this.Controls.Add(this.optionCheckBox);
            this.Controls.Add(this.attachButtonTransform);
            this.Controls.Add(this.transformFileTextBox);
            this.Controls.Add(this.asterikTransformLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.asteriskConfigLabel);
            this.Controls.Add(this.asteriskConfSectionLabel);
            this.Controls.Add(this.asteriskProviderLabel);
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
            this.Controls.Add(this.attachButtonConfig);
            this.Controls.Add(this.configFileTextBox);
            this.Controls.Add(this.introLabel);
            this.Controls.Add(this.configFileLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1024, 768);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1024, 726);
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
        private System.Windows.Forms.Label configFileLabel;
        private System.Windows.Forms.Label introLabel;
        private System.Windows.Forms.TextBox configFileTextBox;
        private System.Windows.Forms.Button attachButtonConfig;
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
        private System.Windows.Forms.Label asteriskConfSectionLabel;
        private System.Windows.Forms.Label asteriskProviderLabel;
        private System.Windows.Forms.Label asteriskConfigLabel;
        private System.Windows.Forms.Button attachButtonTransform;
        private System.Windows.Forms.TextBox transformFileTextBox;
        private System.Windows.Forms.Label asterikTransformLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog transformFileOpenDialog;
        private System.Windows.Forms.CheckBox optionCheckBox;
    }
}

