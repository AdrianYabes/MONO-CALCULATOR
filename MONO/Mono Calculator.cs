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
        String Mono_Operation = "";
        String Num1 = "";
        bool Mono_OperationPerformed = false;

        public Mono()
        {
            InitializeComponent();
        }
        private void m_Load(object sender, EventArgs e)
        {

        }

        private void Operator_Click(object sender, EventArgs e)
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
            Mono_Operation = "+";
            Mono_OperationPerformed = true;
        }
        private void Operator_Subtraction(object sender, EventArgs e)
        {
            Mono_Operation = "-";
            Mono_OperationPerformed = true;
        }
        private void Operator_Multiplication(object sender, EventArgs e)
        {
            Mono_Operation = "*";
            Mono_OperationPerformed = true;
        }
        private void Operator_Division(object sender, EventArgs e)
        {
            Mono_Operation = "/";
            Mono_OperationPerformed = true;
        }
        private void Equal_Button_Click(object sender, EventArgs e)
        {
            if (Mono_Operation.Equals("+"))
                Addition();
            if (Mono_Operation.Equals("-"))
                Subtraction();
            if (Mono_Operation.Equals("*"))
                Multiplication();
            if (Mono_Operation.Equals("/"))
                Division();
        }
        private void Addition()
        {
            Text_Output.Text = (Double.Parse(Num1) + Double.Parse(Text_Output.Text)).ToString();
        }
        private void Subtraction()
        {
            Text_Output.Text = (Double.Parse(Num1) - Double.Parse(Text_Output.Text)).ToString();
        }
        private void Multiplication()
        {
            Text_Output.Text = (Double.Parse(Num1) * Double.Parse(Text_Output.Text)).ToString();
        }
        private void Division()
        {
            Text_Output.Text = (Double.Parse(Num1) / Double.Parse(Text_Output.Text)).ToString();
        }


        private void Append_Num(string Number)
        {
            if (Mono_OperationPerformed)
            {
                Num1 = Text_Output.Text;
                Text_Output.Text = "";
            }
            Text_Output.Text += Number;
            Mono_OperationPerformed = false;
        }

        private void Text_Output_TextChanged(object sender, EventArgs e)
        {
        }

    }
}