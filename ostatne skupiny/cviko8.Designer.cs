namespace Kalkulacka
{
    partial class Form1
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
            labelPrveCislo = new Label();
            buttonVypocitaj = new Button();
            comboBoxOperacie = new ComboBox();
            textBoxPrveCislo = new TextBox();
            textBoxDruheCislo = new TextBox();
            textBoxVysledok = new TextBox();
            buttonKoniec = new Button();
            labelDruheCislo = new Label();
            labelVysledok = new Label();
            SuspendLayout();
            // 
            // labelPrveCislo
            // 
            labelPrveCislo.AutoSize = true;
            labelPrveCislo.Location = new Point(91, 50);
            labelPrveCislo.Name = "labelPrveCislo";
            labelPrveCislo.Size = new Size(100, 30);
            labelPrveCislo.TabIndex = 0;
            labelPrveCislo.Text = "Prvé číslo";
            // 
            // buttonVypocitaj
            // 
            buttonVypocitaj.Location = new Point(283, 319);
            buttonVypocitaj.Name = "buttonVypocitaj";
            buttonVypocitaj.Size = new Size(131, 40);
            buttonVypocitaj.TabIndex = 1;
            buttonVypocitaj.Text = "Vypočítaj";
            buttonVypocitaj.UseVisualStyleBackColor = true;
            buttonVypocitaj.Click += buttonVypocitaj_Click;
            // 
            // comboBoxOperacie
            // 
            comboBoxOperacie.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxOperacie.FormattingEnabled = true;
            comboBoxOperacie.Items.AddRange(new object[] { "+", "-" });
            comboBoxOperacie.Location = new Point(476, 129);
            comboBoxOperacie.Name = "comboBoxOperacie";
            comboBoxOperacie.Size = new Size(103, 38);
            comboBoxOperacie.TabIndex = 2;
            // 
            // textBoxPrveCislo
            // 
            textBoxPrveCislo.Location = new Point(239, 47);
            textBoxPrveCislo.Name = "textBoxPrveCislo";
            textBoxPrveCislo.Size = new Size(175, 35);
            textBoxPrveCislo.TabIndex = 3;
            // 
            // textBoxDruheCislo
            // 
            textBoxDruheCislo.Location = new Point(239, 129);
            textBoxDruheCislo.Name = "textBoxDruheCislo";
            textBoxDruheCislo.Size = new Size(175, 35);
            textBoxDruheCislo.TabIndex = 4;
            // 
            // textBoxVysledok
            // 
            textBoxVysledok.Location = new Point(239, 214);
            textBoxVysledok.Name = "textBoxVysledok";
            textBoxVysledok.ReadOnly = true;
            textBoxVysledok.Size = new Size(175, 35);
            textBoxVysledok.TabIndex = 5;
            // 
            // buttonKoniec
            // 
            buttonKoniec.Location = new Point(91, 319);
            buttonKoniec.Name = "buttonKoniec";
            buttonKoniec.Size = new Size(131, 40);
            buttonKoniec.TabIndex = 6;
            buttonKoniec.Text = "Koniec";
            buttonKoniec.UseVisualStyleBackColor = true;
            buttonKoniec.Click += buttonKoniec_Click;
            // 
            // labelDruheCislo
            // 
            labelDruheCislo.AutoSize = true;
            labelDruheCislo.Location = new Point(91, 129);
            labelDruheCislo.Name = "labelDruheCislo";
            labelDruheCislo.Size = new Size(117, 30);
            labelDruheCislo.TabIndex = 7;
            labelDruheCislo.Text = "Druhé číslo";
            // 
            // labelVysledok
            // 
            labelVysledok.AutoSize = true;
            labelVysledok.Location = new Point(91, 214);
            labelVysledok.Name = "labelVysledok";
            labelVysledok.Size = new Size(95, 30);
            labelVysledok.TabIndex = 8;
            labelVysledok.Text = "Výsledok";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(655, 401);
            Controls.Add(labelVysledok);
            Controls.Add(labelDruheCislo);
            Controls.Add(buttonKoniec);
            Controls.Add(textBoxVysledok);
            Controls.Add(textBoxDruheCislo);
            Controls.Add(textBoxPrveCislo);
            Controls.Add(comboBoxOperacie);
            Controls.Add(buttonVypocitaj);
            Controls.Add(labelPrveCislo);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelPrveCislo;
        private Button buttonVypocitaj;
        private ComboBox comboBoxOperacie;
        private TextBox textBoxPrveCislo;
        private TextBox textBoxDruheCislo;
        private TextBox textBoxVysledok;
        private Button buttonKoniec;
        private Label labelDruheCislo;
        private Label labelVysledok;
    }
}
