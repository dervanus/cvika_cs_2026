namespace textovyEditor
{
    partial class VedlajsieOkno
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
            riadkyLabel = new Label();
            slovaLabel = new Label();
            SuspendLayout();
            // 
            // riadkyLabel
            // 
            riadkyLabel.AutoSize = true;
            riadkyLabel.Location = new Point(59, 43);
            riadkyLabel.Name = "riadkyLabel";
            riadkyLabel.Size = new Size(68, 30);
            riadkyLabel.TabIndex = 0;
            riadkyLabel.Text = "label1";
            // 
            // slovaLabel
            // 
            slovaLabel.AutoSize = true;
            slovaLabel.Location = new Point(59, 115);
            slovaLabel.Name = "slovaLabel";
            slovaLabel.Size = new Size(68, 30);
            slovaLabel.TabIndex = 1;
            slovaLabel.Text = "label2";
            // 
            // VedlajsieOkno
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(616, 206);
            Controls.Add(slovaLabel);
            Controls.Add(riadkyLabel);
            Name = "VedlajsieOkno";
            Text = "Štatistika";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label riadkyLabel;
        private Label slovaLabel;
    }
}