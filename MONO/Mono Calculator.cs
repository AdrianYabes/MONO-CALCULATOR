using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MONO
{
    public partial class Mono : Form
    {
        OperatorClass Calculator = new OperatorClass();
        public Mono()
        {
            InitializeComponent();
        }
        private void One_Button_Click(object sender, EventArgs e)
        {
            Append_Num("1");
        }
        private void Two_Button_Click(object sender, EventArgs e)
        {
            Append_Num("2");
        }
        private void Three_Button_Click(object sender, EventArgs e)
        {
            Append_Num("3");
        }
        private void Four_Button_Click(object sender, EventArgs e)
        {
            Append_Num("4");
        }
        private void Five_Button_Click(object sender, EventArgs e)
        {
            Append_Num("5");
        }
        private void Six_Button_Click(object sender, EventArgs e)
        {
            Append_Num("6");
        }
        private void Seven_Button_Click(object sender, EventArgs e)
        {
            Append_Num("7");
        }
        private void Eight_Button_Click(object sender, EventArgs e)
        {
            Append_Num("8");
        }
        private void Nine_Button_Click(object sender, EventArgs e)
        {
            Append_Num("9");
        }
        private void Zero_Button_Click(object sender, EventArgs e)
        {
            Append_Num("0");
        }
        private void Point_Button_Click(object sender, EventArgs e)
        {
            Append_Num(".");
        }
        private void Operator_Addition(object sender, EventArgs e)
        {
            Calculator.Mono_Operation = "+";
            Calculator.Mono_OperationPerformed = true;
        }
        private void Operator_Subtraction(object sender, EventArgs e)
        {
            Calculator.Mono_Operation = "-";
            Calculator.Mono_OperationPerformed = true;
        }
        private void Operator_Multiplication(object sender, EventArgs e)
        {
            Calculator.Mono_Operation = "*";
            Calculator.Mono_OperationPerformed = true;
        }
        private void Operator_Division(object sender, EventArgs e)
        {
            Calculator.Mono_Operation = "/";
            Calculator.Mono_OperationPerformed = true;
        }
        private void Equal_Button_Click(object sender, EventArgs e)
        {
            Calculator.Num2 = Text_Output.Text;
            switch (Calculator.Mono_Operation)
            {
                case "+":
                    Calculator.Addition();
                    Text_Output.Text = Calculator.Num2;
                    break;
                case "-":
                    Calculator.Subtraction();
                    Text_Output.Text = Calculator.Num2;
                    break;
                case "*":
                    Calculator.Multiplication();
                    Text_Output.Text = Calculator.Num2;
                    break;
                case "/":
                    Calculator.Division();
                    Text_Output.Text = Calculator.Num2;
                    break;
                default:
                    break;
            }
        }
        private void Append_Num(string Number)
        {
            if (Calculator.Mono_OperationPerformed)
            {
                Calculator.Num1 = Text_Output.Text;
                Text_Output.Text = "";
            }
            Text_Output.Text += Number;
            Calculator.Mono_OperationPerformed = false;
        }
        private void Text_Output_TextChanged(object sender, EventArgs e)
        {
        }
        private void Clear_Button_Click(object sender, EventArgs e)
        {
            Text_Output.Text = "";
        }
        private void CE_Button_Click(object sender, EventArgs e)
        {
            Text_Output.Text = "";
        }
    }
}