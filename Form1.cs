using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_by_Stephanie_ML
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            int c;
            if (radioButton1.Checked)
            {
                c = a + b;
                label4.Text = "Total=" + c.ToString();
            }


        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            int c;
            if (radioButton1.Checked)
            {
                c = a + b;
                label4.Text = "Total= " + c.ToString();
            }
            if (radioButton2.Checked)
            {
                c = a - b;
                label4.Text = "Subtract= " + c.ToString();
            }
            if (radioButton3.Checked)
            {
                c = a * b;
                label4.Text = "Multiple= " + c.ToString();
            }
            if (radioButton4.Checked)
            {
                c = a / b;
                label4.Text = "Divide= " + c.ToString();
            }
            if (radioButton5.Checked)
            {
                c = a % b;
                label4.Text = "Module= " + c.ToString();
            }
        }

    }
}

           
