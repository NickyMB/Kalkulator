using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button0_Click(object sender, EventArgs e)
        {
            ShowText(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowText(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShowText(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ShowText(3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ShowText(4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ShowText(5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ShowText(6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ShowText(7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ShowText(8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ShowText(9);
        }
        private void ShowText(int x)
        {
            TextBoxMain.Text += x.ToString();
        }
    }
}
