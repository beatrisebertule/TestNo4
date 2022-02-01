using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestNo4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            labelbea.Visible = false;
        }

        private void buttonbea_Click(object sender, EventArgs e)
        {
            labelbea.Visible = true;
            labelbea.ForeColor = System.Drawing.Color.Black;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            labelbea.ForeColor = System.Drawing.Color.Green;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            labelbea.ForeColor = System.Drawing.Color.Blue;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            labelbea.ForeColor = System.Drawing.Color.Red;

        }

        private void buttonExtra_Click(object sender, EventArgs e)
        {
            buttonExtra2.Visible = true;
        }

        private void buttonExtra2_Click(object sender, EventArgs e)
        {
            buttonExtra3.Visible = true;
        }

        private void buttonExtra3_Click(object sender, EventArgs e)
        {
            buttonExtra4.Visible = true;
        }

        private void buttonExtra4_Click(object sender, EventArgs e)
        {
            buttonExtra.Visible = false;
            buttonExtra2.Visible = false;
            buttonExtra3.Visible = false;
            buttonExtra4.Visible = false;
            label1.Visible = true;
        }
    }
}
