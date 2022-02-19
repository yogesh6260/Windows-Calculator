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
    public partial class Form1 : Form
    {
        Double resultValue = 0;
        String operationPerformed = "";
        bool isOperationPerformed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
            if((txtbox_Result.Text == "0") || (isOperationPerformed))
            {
                txtbox_Result.Clear();
            }
            isOperationPerformed = false;
            Button button = (Button)sender;
            if(button.Text == ".")
            {
                if(!txtbox_Result.Text.Contains("."))
                {
                    txtbox_Result.Text = txtbox_Result.Text + button.Text;
                }
            }else
            txtbox_Result.Text = txtbox_Result.Text + button.Text;
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if(resultValue != 0)
            {
                btnEqual.PerformClick();
                operationPerformed = button.Text;
                lblCurrent_Operation.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            }
            else
            {
                operationPerformed = button.Text;
                resultValue = Double.Parse(txtbox_Result.Text);
                lblCurrent_Operation.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            }
            

        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtbox_Result.Text = "0";
            resultValue = 0;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            switch(operationPerformed)
            {
                case "+":
                    txtbox_Result.Text = (resultValue + Double.Parse(txtbox_Result.Text)).ToString();
                    break;
                case "-":
                    txtbox_Result.Text = (resultValue - Double.Parse(txtbox_Result.Text)).ToString();
                    break;
                case "*":
                    txtbox_Result.Text = (resultValue * Double.Parse(txtbox_Result.Text)).ToString();
                    break;
                case "/":
                    txtbox_Result.Text = (resultValue / Double.Parse(txtbox_Result.Text)).ToString();
                    break;
                default:
                    break;
            }
            resultValue = Double.Parse(txtbox_Result.Text);
            lblCurrent_Operation.Text = "";
        }
    }
}
