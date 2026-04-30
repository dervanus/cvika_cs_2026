namespace textovyEditor
{
    partial class HlavneOkno
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
            suborMenuStrip = new MenuStrip();
            súborToolStripMenuItem = new ToolStripMenuItem();
            otvoriťToolStripMenuItem = new ToolStripMenuItem();
            uložiťToolStripMenuItem = new ToolStripMenuItem();
            vymazaťPoleToolStripMenuItem = new ToolStripMenuItem();
            koniecToolStripMenuItem = new ToolStripMenuItem();
            infoToolStripMenuItem = new ToolStripMenuItem();
            štatistikaToolStripMenuItem = new ToolStripMenuItem();
            oAutorochToolStripMenuItem = new ToolStripMenuItem();
            suborTextBox = new TextBox();
            editorOpenFileDialog = new OpenFileDialog();
            editorSaveFileDialog = new SaveFileDialog();
            suborMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // suborMenuStrip
            // 
            suborMenuStrip.ImageScalingSize = new Size(28, 28);
            suborMenuStrip.Items.AddRange(new ToolStripItem[] { súborToolStripMenuItem, infoToolStripMenuItem });
            suborMenuStrip.Location = new Point(0, 0);
            suborMenuStrip.Name = "suborMenuStrip";
            suborMenuStrip.Size = new Size(1035, 38);
            suborMenuStrip.TabIndex = 0;
            suborMenuStrip.Text = "menuStrip1";
            // 
            // súborToolStripMenuItem
            // 
            súborToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { otvoriťToolStripMenuItem, uložiťToolStripMenuItem, vymazaťPoleToolStripMenuItem, koniecToolStripMenuItem });
            súborToolStripMenuItem.Name = "súborToolStripMenuItem";
            súborToolStripMenuItem.Size = new Size(85, 34);
            súborToolStripMenuItem.Text = "Súbor";
            // 
            // otvoriťToolStripMenuItem
            // 
            otvoriťToolStripMenuItem.Name = "otvoriťToolStripMenuItem";
            otvoriťToolStripMenuItem.Size = new Size(259, 40);
            otvoriťToolStripMenuItem.Text = "Otvoriť";
            otvoriťToolStripMenuItem.Click += otvoriťToolStripMenuItem_Click;
            // 
            // uložiťToolStripMenuItem
            // 
            uložiťToolStripMenuItem.Name = "uložiťToolStripMenuItem";
            uložiťToolStripMenuItem.Size = new Size(259, 40);
            uložiťToolStripMenuItem.Text = "Uložiť";
            uložiťToolStripMenuItem.Click += uložiťToolStripMenuItem_Click;
            // 
            // vymazaťPoleToolStripMenuItem
            // 
            vymazaťPoleToolStripMenuItem.Name = "vymazaťPoleToolStripMenuItem";
            vymazaťPoleToolStripMenuItem.Size = new Size(259, 40);
            vymazaťPoleToolStripMenuItem.Text = "Vymazať pole";
            vymazaťPoleToolStripMenuItem.Click += vymazaťPoleToolStripMenuItem_Click;
            // 
            // koniecToolStripMenuItem
            // 
            koniecToolStripMenuItem.Name = "koniecToolStripMenuItem";
            koniecToolStripMenuItem.Size = new Size(259, 40);
            koniecToolStripMenuItem.Text = "Koniec";
            koniecToolStripMenuItem.Click += koniecToolStripMenuItem_Click;
            // 
            // infoToolStripMenuItem
            // 
            infoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { štatistikaToolStripMenuItem, oAutorochToolStripMenuItem });
            infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            infoToolStripMenuItem.Size = new Size(68, 34);
            infoToolStripMenuItem.Text = "Info";
            // 
            // štatistikaToolStripMenuItem
            // 
            štatistikaToolStripMenuItem.Name = "štatistikaToolStripMenuItem";
            štatistikaToolStripMenuItem.Size = new Size(315, 40);
            štatistikaToolStripMenuItem.Text = "Štatistika";
            štatistikaToolStripMenuItem.Click += štatistikaToolStripMenuItem_Click;
            // 
            // oAutorochToolStripMenuItem
            // 
            oAutorochToolStripMenuItem.Name = "oAutorochToolStripMenuItem";
            oAutorochToolStripMenuItem.Size = new Size(315, 40);
            oAutorochToolStripMenuItem.Text = "O autoroch";
            oAutorochToolStripMenuItem.Click += oAutorochToolStripMenuItem_Click;
            // 
            // suborTextBox
            // 
            suborTextBox.Location = new Point(41, 66);
            suborTextBox.Multiline = true;
            suborTextBox.Name = "suborTextBox";
            suborTextBox.ScrollBars = ScrollBars.Vertical;
            suborTextBox.Size = new Size(966, 515);
            suborTextBox.TabIndex = 1;
            // 
            // editorOpenFileDialog
            // 
            editorOpenFileDialog.FileName = "openFileDialog1";
            // 
            // HlavneOkno
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1035, 621);
            Controls.Add(suborTextBox);
            Controls.Add(suborMenuStrip);
            MainMenuStrip = suborMenuStrip;
            Name = "HlavneOkno";
            Text = "Editor";
            suborMenuStrip.ResumeLayout(false);
            suborMenuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip suborMenuStrip;
        private ToolStripMenuItem súborToolStripMenuItem;
        private ToolStripMenuItem otvoriťToolStripMenuItem;
        private ToolStripMenuItem uložiťToolStripMenuItem;
        private ToolStripMenuItem vymazaťPoleToolStripMenuItem;
        private ToolStripMenuItem koniecToolStripMenuItem;
        private ToolStripMenuItem infoToolStripMenuItem;
        private ToolStripMenuItem štatistikaToolStripMenuItem;
        private ToolStripMenuItem oAutorochToolStripMenuItem;
        private TextBox suborTextBox;
        private OpenFileDialog editorOpenFileDialog;
        private SaveFileDialog editorSaveFileDialog;
    }
}
