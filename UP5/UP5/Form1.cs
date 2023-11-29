using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UP5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            file1.Filter = "(*.jpg)|*.jpg*";
        }

        private void btc_Click(object sender, EventArgs e)
        {
            string fname;
            file1.ShowDialog();
            fname = file1.FileName;
            pct.Image = Image.FromFile(fname);
            imya.Text = fname;
        }

        private void btcSave_Click(object sender, EventArgs e)
        {

        }
    }
}
