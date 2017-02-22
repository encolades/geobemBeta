using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace geobemBeta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radButtonElement5_Click(object sender, EventArgs e)
        {
            help frm2 = new help();
            frm2.ShowDialog();
        }
    }
}
