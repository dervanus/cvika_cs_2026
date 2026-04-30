namespace Kebab
{
    public partial class KebabForm : Form
    {
        private double celkovaCena;
        private RadioButton sucasneMaso;
        public KebabForm()
        {
            InitializeComponent();
            celkovaCena = 5; //defaultne je zvolene kuracie
            cenaLabel.Text = "celková cena: " + celkovaCena + "€";
            sucasneMaso = kuracieRadioButton;
        }

        private void hovadzieRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            if (rb.Checked)
            {
                if(sucasneMaso == kuracieRadioButton)
                {
                    celkovaCena += 1;
                }
                if(rb == kuracieRadioButton)
                {
                    celkovaCena -= 1;
                }
            }
            sucasneMaso = rb;
            cenaLabel.Text = "celková cena: " + celkovaCena + "€";
        }

        private void sHranolkamiRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            if (rb.Checked)
            {
                if(rb == sHranolkamiRadioButton)
                {
                    celkovaCena += 1;
                }
                if(rb == bezHranoliekRadioButton)
                {
                    celkovaCena -= 1;
                }
            }
            cenaLabel.Text = "celková cena: " + celkovaCena + "€";
        }

        private void kapustaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;
            if (cb.Checked)
            {
                celkovaCena += 0.5;
            }
            else
            {
                celkovaCena -= 0.5;
            }
            cenaLabel.Text = "celková cena: " + celkovaCena + "€";
        }

        private void suhlasCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;
            if(cb.Checked)
            {
                ulozitPanel.Enabled = true;
            }
            else
            {
                ulozitPanel.Enabled = false;
            }
        }

        private void menoTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                ulozitButton.PerformClick();
                e.SuppressKeyPress = true; //potlaci ten zvuk
            }
        }

        private void ulozitButton_Click(object sender, EventArgs e)
        {
            //nastavenie na defaultne hodnoty
            kuracieRadioButton.Checked = true;
            bezHranoliekRadioButton.Checked = true;
            cibulaCheckBox.Checked = false;
            rajcinaCheckBox.Checked = false;
            kapustaCheckBox.Checked = false;
            menoTextBox.Text = "";
            suhlasCheckBox.Checked = false;
            celkovaCena = 5;
            cenaLabel.Text = "celková cena: " + celkovaCena + "€";
            sucasneMaso = kuracieRadioButton;
        }
    }
}
