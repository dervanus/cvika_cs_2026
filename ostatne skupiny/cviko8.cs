namespace Kalkuacka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBoxOperacie.Items.Add("+");
            comboBoxOperacie.Items.Add("-");
            comboBoxOperacie.Items.Add("*");
            comboBoxOperacie.Items.Add("/");
            comboBoxOperacie.SelectedIndex = 0;
        }

        private void buttonVypocitaj_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(textBoxPrveCislo.Text);
                int b = int.Parse(textBoxDruheCislo.Text);
                int c = 0;
                switch (comboBoxOperacie.SelectedItem)
                {
                    case "+":
                        c = a + b;
                        break;
                    case "-":
                        c = a - b;
                        break;
                    case "*":
                        c = a * b;
                        break;
                    case "/":
                        c = a / b;
                        break;
                }
                textBoxVysledok.Text = c.ToString();
            }
            catch (FormatException)
            {
                textBoxVysledok.Text = "Syntax Error";
            }
        }

        private void buttonKoniec_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
