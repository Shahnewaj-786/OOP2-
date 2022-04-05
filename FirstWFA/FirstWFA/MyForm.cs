using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstWFA
{
    public partial class MyForm : Form
    {
        public MyForm()
        {
            InitializeComponent();
        }

        private void MyForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void clickButton_Click(object sender, EventArgs e)
        {
            //clickButton.Text = "Hola";

            //if (clickButton.Text == "Click")
            //{
            //    clickButton.Text = "Hola";
            //}
            //else
            //{
            //    clickButton.Text = "Click";
            //}

            //label1.Text = "You have click the button";

            //label1.Text = textBox1.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            label1.Text = "u choose java";
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            label1.Text = "u choose c#";
        }
    }
}
