using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static void DH_Convert(double amount, char money)
        {
            //// Dirham to euros
            //if (money == 'd')
            //{
            //    amount *= 0.095;
            //}

            //// Euros to dirahm
            //else if (money == 'e')
            //{
            //    amount *= 10.51;
            //}
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //if (string.IsNullOrWhiteSpace(textBox2.Text))
            //{
             textBox1.Text = "Amount in Dirhams";
            //}
            ////DH_Convert(10, 'd');
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
        //    if (string.IsNullOrWhiteSpace(textBox1.Text))
        //    {
            textBox2.Text = "Amount in Euros";
        //    }
        //    //textBox2.Text = "Hello";
        //    // DH_Convert(10, 'd');
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            if (radioButton1.Checked)
            {
                textBox1.Text = "rrrrrr";
            }
            else if(radioButton2.Checked)
            {
                textBox2.Text = "ddddd";
            }
            MessageBox.Show("hello");
        }
    }
}
