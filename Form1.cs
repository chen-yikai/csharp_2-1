using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAIHS_CS_2_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            double inch = Convert.ToDouble(textBox6.Text);
            double cm = inch * 2.54;
            label8.Text = cm.ToString();
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            double cm = Convert.ToDouble(textBox7.Text);
            double inch = cm / 2.54;
            label11.Text = inch.ToString();
        }
    }
}
