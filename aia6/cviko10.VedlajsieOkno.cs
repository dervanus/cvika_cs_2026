using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace textovyEditor
{
    public partial class VedlajsieOkno : Form
    {
        public VedlajsieOkno(TextBox tb)
        {
            InitializeComponent();
            riadkyLabel.Text = tb.Text.Split('\n').Length.ToString();
            slovaLabel.Text = tb.Text.Split(new char[] {'\n', ' '}).Length.ToString();
        }
    }
}
