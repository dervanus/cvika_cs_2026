namespace textovyEditor
{
    public partial class HlavneOkno : Form
    {
        public HlavneOkno()
        {
            InitializeComponent();
        }

        private void otvoriťToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editorOpenFileDialog.Filter = "Textové súbory|*.txt|Všetky súbory|*.*";
            DialogResult dr = editorOpenFileDialog.ShowDialog();
            if (dr == DialogResult.OK)
            {
                suborTextBox.Text = File.ReadAllText(editorOpenFileDialog.FileName);
            }
        }

        private void uložiťToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editorSaveFileDialog.Filter = "Textové súbory|*.txt|Všetky súbory|*.*";
            DialogResult dr = editorSaveFileDialog.ShowDialog();
            if (dr == DialogResult.OK)
            {
                File.WriteAllText(editorSaveFileDialog.FileName, suborTextBox.Text);
            }
        }

        private void vymazaťPoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            suborTextBox.Text = "";
        }

        private void koniecToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void štatistikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VedlajsieOkno o = new VedlajsieOkno(suborTextBox);
            o.ShowDialog();
        }

        private void oAutorochToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("(c) Janko Hraško, 2026", "O autoroch");
        }
    }
}
