using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class CalculatorWindow : Form
    {
        double value = 0;
        string operation = " ";
        bool operation_pressed = false;

        public CalculatorWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((tbResult.Text == "0")||(operation_pressed))
                tbResult.Clear();
            operation_pressed = false;
            Button button = sender as Button;
            if (button.Text == ".")
            {
                if (!tbResult.Text.Contains("."))
                {
                    this.tbResult.Text = tbResult.Text + button.Text;
                }
            }
            else
                this.tbResult.Text = tbResult.Text + button.Text;
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            tbResult.Text = "0";
        }

        private void operator_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (value != 0)
            {
                btnCE.PerformClick();
                operation_pressed = true;
                operation = button.Text;
                lEquation.Text = value + "" + operation;
            }
            else
            {
                operation = button.Text;
                value = double.Parse(tbResult.Text);
                operation_pressed = true;
                lEquation.Text = value + "" + operation;
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            lEquation.Text = " ";
            switch (operation)
            {
                case "+":
                    tbResult.Text = (value + double.Parse(tbResult.Text)).ToString();
                    break;
                case "-":
                    tbResult.Text = (value - double.Parse(tbResult.Text)).ToString();
                    break;
                case "/":
                    tbResult.Text = (value / double.Parse(tbResult.Text)).ToString();
                    break;
                case "*":
                    tbResult.Text = (value * double.Parse(tbResult.Text)).ToString();
                    break;
                default:
                    break;
            }

            value = double.Parse(tbResult.Text);
            operation = "";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            tbResult.Clear();
            value = 0;
            lEquation.Text = "";
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar.ToString())
            {
                case "0":
                    zero.PerformClick();
                    break;
                case "1":
                    one.PerformClick();
                    break;
                case "2":
                    two.PerformClick();
                    break;
                case "3":
                    three.PerformClick();
                    break;
                case "4":
                    four.PerformClick();
                    break;
                case "5":
                    five.PerformClick();
                    break;
                case "6":
                    six.PerformClick();
                    break;
                case "7":
                    seven.PerformClick();
                    break;
                case "8":
                    eight.PerformClick();
                    break;
                case "9":
                    nine.PerformClick();
                    break;
                case "+":
                    add.PerformClick();
                    break;
                case "-":
                    sub.PerformClick();
                    break;
                case "*":
                    times.PerformClick();
                    break;
                case "/":
                    div.PerformClick();
                    break;
                case "=":
                    equal.PerformClick();
                    break;

                default:
                    break;
            }
        }

        
    }
}
