using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCalculator
{
    public partial class Form1 : Form
    {
        //string operations = "";
        decimal number;
        bool isClicked;
        string operation;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Icon myIcon = new Icon(@"C:\Users\P501\Desktop\calcIcon.ico");
            this.BackColor = Color.White;
            // this.Icon = myIcon;
            this.Name = "calculator";
            this.Text = "Calculator";
            textBox1.ForeColor = Color.White;
            label1.Size = new Size(100, 10);
            textBox1.Text = "0";
        }
        private void myValue(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || (this.isClicked))
            {
                textBox1.Clear();
                isClicked = false;
            }


            Button myNum = sender as Button;
            textBox1.Text += myNum.Text;
        }
        private void myOperand(object sender, EventArgs e)
        {
            Button myOp = sender as Button;
            label1.Text += textBox1.Text + myOp.Text;
            operation = myOp.Text;
            number = Convert.ToDecimal(textBox1.Text);
            isClicked = true;


        }
        private void result(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    textBox1.Text = (number + Convert.ToDecimal(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (number - Convert.ToDecimal(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (number * Convert.ToDecimal(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (number / Convert.ToDecimal(textBox1.Text)).ToString();
                    break;
            }
            label1.Text = "";

        }

        private void clear(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            label1.Text = "";
        }
    }
}
