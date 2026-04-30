namespace Kebab
{
    partial class KebabForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            masoGroupBox = new GroupBox();
            hovadzieRadioButton = new RadioButton();
            telacieRadioButton = new RadioButton();
            kuracieRadioButton = new RadioButton();
            zeleninaGroupBox = new GroupBox();
            kapustaCheckBox = new CheckBox();
            rajcinaCheckBox = new CheckBox();
            cibulaCheckBox = new CheckBox();
            panelHranolky = new Panel();
            sHranolkamiRadioButton = new RadioButton();
            bezHranoliekRadioButton = new RadioButton();
            menoTextBox = new TextBox();
            menoLabel = new Label();
            suhlasCheckBox = new CheckBox();
            ulozitPanel = new Panel();
            ulozitButton = new Button();
            cenaLabel = new Label();
            masoGroupBox.SuspendLayout();
            zeleninaGroupBox.SuspendLayout();
            panelHranolky.SuspendLayout();
            ulozitPanel.SuspendLayout();
            SuspendLayout();
            // 
            // masoGroupBox
            // 
            masoGroupBox.Controls.Add(hovadzieRadioButton);
            masoGroupBox.Controls.Add(telacieRadioButton);
            masoGroupBox.Controls.Add(kuracieRadioButton);
            masoGroupBox.Location = new Point(40, 41);
            masoGroupBox.Name = "masoGroupBox";
            masoGroupBox.Size = new Size(276, 338);
            masoGroupBox.TabIndex = 0;
            masoGroupBox.TabStop = false;
            masoGroupBox.Text = "Mäso";
            // 
            // hovadzieRadioButton
            // 
            hovadzieRadioButton.AutoSize = true;
            hovadzieRadioButton.Location = new Point(40, 176);
            hovadzieRadioButton.Name = "hovadzieRadioButton";
            hovadzieRadioButton.Size = new Size(149, 34);
            hovadzieRadioButton.TabIndex = 2;
            hovadzieRadioButton.Text = "hovädzie 6e";
            hovadzieRadioButton.UseVisualStyleBackColor = true;
            hovadzieRadioButton.CheckedChanged += hovadzieRadioButton_CheckedChanged;
            // 
            // telacieRadioButton
            // 
            telacieRadioButton.AutoSize = true;
            telacieRadioButton.Location = new Point(40, 117);
            telacieRadioButton.Name = "telacieRadioButton";
            telacieRadioButton.Size = new Size(127, 34);
            telacieRadioButton.TabIndex = 1;
            telacieRadioButton.Text = "teľacie 6e";
            telacieRadioButton.UseVisualStyleBackColor = true;
            telacieRadioButton.CheckedChanged += hovadzieRadioButton_CheckedChanged;
            // 
            // kuracieRadioButton
            // 
            kuracieRadioButton.AutoSize = true;
            kuracieRadioButton.Checked = true;
            kuracieRadioButton.Location = new Point(40, 61);
            kuracieRadioButton.Name = "kuracieRadioButton";
            kuracieRadioButton.Size = new Size(132, 34);
            kuracieRadioButton.TabIndex = 0;
            kuracieRadioButton.TabStop = true;
            kuracieRadioButton.Text = "kuracie 5€";
            kuracieRadioButton.UseVisualStyleBackColor = true;
            kuracieRadioButton.CheckedChanged += hovadzieRadioButton_CheckedChanged;
            // 
            // zeleninaGroupBox
            // 
            zeleninaGroupBox.Controls.Add(kapustaCheckBox);
            zeleninaGroupBox.Controls.Add(rajcinaCheckBox);
            zeleninaGroupBox.Controls.Add(cibulaCheckBox);
            zeleninaGroupBox.Location = new Point(659, 53);
            zeleninaGroupBox.Name = "zeleninaGroupBox";
            zeleninaGroupBox.Size = new Size(254, 265);
            zeleninaGroupBox.TabIndex = 1;
            zeleninaGroupBox.TabStop = false;
            zeleninaGroupBox.Text = "Zelenina";
            // 
            // kapustaCheckBox
            // 
            kapustaCheckBox.AutoSize = true;
            kapustaCheckBox.Location = new Point(30, 174);
            kapustaCheckBox.Name = "kapustaCheckBox";
            kapustaCheckBox.Size = new Size(169, 34);
            kapustaCheckBox.TabIndex = 2;
            kapustaCheckBox.Text = "kapusta +0,5€";
            kapustaCheckBox.UseVisualStyleBackColor = true;
            kapustaCheckBox.CheckedChanged += kapustaCheckBox_CheckedChanged;
            // 
            // rajcinaCheckBox
            // 
            rajcinaCheckBox.AutoSize = true;
            rajcinaCheckBox.Location = new Point(30, 117);
            rajcinaCheckBox.Name = "rajcinaCheckBox";
            rajcinaCheckBox.Size = new Size(158, 34);
            rajcinaCheckBox.TabIndex = 1;
            rajcinaCheckBox.Text = "rajčina +0,5€";
            rajcinaCheckBox.UseVisualStyleBackColor = true;
            rajcinaCheckBox.CheckedChanged += kapustaCheckBox_CheckedChanged;
            // 
            // cibulaCheckBox
            // 
            cibulaCheckBox.AutoSize = true;
            cibulaCheckBox.Location = new Point(30, 62);
            cibulaCheckBox.Name = "cibulaCheckBox";
            cibulaCheckBox.Size = new Size(153, 34);
            cibulaCheckBox.TabIndex = 0;
            cibulaCheckBox.Text = "cibuľa +0,5€";
            cibulaCheckBox.UseVisualStyleBackColor = true;
            cibulaCheckBox.CheckedChanged += kapustaCheckBox_CheckedChanged;
            // 
            // panelHranolky
            // 
            panelHranolky.Controls.Add(sHranolkamiRadioButton);
            panelHranolky.Controls.Add(bezHranoliekRadioButton);
            panelHranolky.Location = new Point(366, 53);
            panelHranolky.Name = "panelHranolky";
            panelHranolky.Size = new Size(253, 181);
            panelHranolky.TabIndex = 2;
            // 
            // sHranolkamiRadioButton
            // 
            sHranolkamiRadioButton.AutoSize = true;
            sHranolkamiRadioButton.Location = new Point(26, 87);
            sHranolkamiRadioButton.Name = "sHranolkamiRadioButton";
            sHranolkamiRadioButton.Size = new Size(198, 34);
            sHranolkamiRadioButton.TabIndex = 1;
            sHranolkamiRadioButton.Text = "s hranolkami +1€";
            sHranolkamiRadioButton.UseVisualStyleBackColor = true;
            sHranolkamiRadioButton.CheckedChanged += sHranolkamiRadioButton_CheckedChanged;
            // 
            // bezHranoliekRadioButton
            // 
            bezHranoliekRadioButton.AutoSize = true;
            bezHranoliekRadioButton.Checked = true;
            bezHranoliekRadioButton.Location = new Point(26, 36);
            bezHranoliekRadioButton.Name = "bezHranoliekRadioButton";
            bezHranoliekRadioButton.Size = new Size(162, 34);
            bezHranoliekRadioButton.TabIndex = 0;
            bezHranoliekRadioButton.TabStop = true;
            bezHranoliekRadioButton.Text = "bez hranoliek";
            bezHranoliekRadioButton.UseVisualStyleBackColor = true;
            bezHranoliekRadioButton.CheckedChanged += sHranolkamiRadioButton_CheckedChanged;
            // 
            // menoTextBox
            // 
            menoTextBox.Location = new Point(539, 349);
            menoTextBox.Name = "menoTextBox";
            menoTextBox.Size = new Size(374, 35);
            menoTextBox.TabIndex = 3;
            menoTextBox.KeyDown += menoTextBox_KeyDown;
            // 
            // menoLabel
            // 
            menoLabel.AutoSize = true;
            menoLabel.Location = new Point(446, 352);
            menoLabel.Name = "menoLabel";
            menoLabel.Size = new Size(72, 30);
            menoLabel.TabIndex = 4;
            menoLabel.Text = "Meno:";
            // 
            // suhlasCheckBox
            // 
            suhlasCheckBox.AutoSize = true;
            suhlasCheckBox.Location = new Point(397, 409);
            suhlasCheckBox.Name = "suhlasCheckBox";
            suhlasCheckBox.Size = new Size(267, 34);
            suhlasCheckBox.TabIndex = 5;
            suhlasCheckBox.Text = "súhlasím s podmienkami";
            suhlasCheckBox.UseVisualStyleBackColor = true;
            suhlasCheckBox.CheckedChanged += suhlasCheckBox_CheckedChanged;
            // 
            // ulozitPanel
            // 
            ulozitPanel.Controls.Add(ulozitButton);
            ulozitPanel.Controls.Add(cenaLabel);
            ulozitPanel.Enabled = false;
            ulozitPanel.Location = new Point(173, 478);
            ulozitPanel.Name = "ulozitPanel";
            ulozitPanel.Size = new Size(705, 103);
            ulozitPanel.TabIndex = 6;
            // 
            // ulozitButton
            // 
            ulozitButton.Location = new Point(383, 35);
            ulozitButton.Name = "ulozitButton";
            ulozitButton.Size = new Size(131, 40);
            ulozitButton.TabIndex = 1;
            ulozitButton.Text = "uložiť";
            ulozitButton.UseVisualStyleBackColor = true;
            ulozitButton.Click += ulozitButton_Click;
            // 
            // cenaLabel
            // 
            cenaLabel.AutoSize = true;
            cenaLabel.Location = new Point(88, 39);
            cenaLabel.Name = "cenaLabel";
            cenaLabel.Size = new Size(68, 30);
            cenaLabel.TabIndex = 0;
            cenaLabel.Text = "label1";
            // 
            // KebabForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1049, 611);
            Controls.Add(ulozitPanel);
            Controls.Add(suhlasCheckBox);
            Controls.Add(menoLabel);
            Controls.Add(menoTextBox);
            Controls.Add(panelHranolky);
            Controls.Add(zeleninaGroupBox);
            Controls.Add(masoGroupBox);
            Name = "KebabForm";
            Text = "Kebab";
            masoGroupBox.ResumeLayout(false);
            masoGroupBox.PerformLayout();
            zeleninaGroupBox.ResumeLayout(false);
            zeleninaGroupBox.PerformLayout();
            panelHranolky.ResumeLayout(false);
            panelHranolky.PerformLayout();
            ulozitPanel.ResumeLayout(false);
            ulozitPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox masoGroupBox;
        private RadioButton hovadzieRadioButton;
        private RadioButton telacieRadioButton;
        private RadioButton kuracieRadioButton;
        private GroupBox zeleninaGroupBox;
        private Panel panelHranolky;
        private RadioButton bezHranoliekRadioButton;
        private RadioButton sHranolkamiRadioButton;
        private CheckBox kapustaCheckBox;
        private CheckBox rajcinaCheckBox;
        private CheckBox cibulaCheckBox;
        private TextBox menoTextBox;
        private Label menoLabel;
        private CheckBox suhlasCheckBox;
        private Panel ulozitPanel;
        private Button ulozitButton;
        private Label cenaLabel;
    }
}
