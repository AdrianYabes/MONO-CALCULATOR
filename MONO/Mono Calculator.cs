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
        Double Mono_Result = 0;
        String Mono_Operation = "";
        bool Mono_OperationPerformed = false;

        public Mono()
        {
            InitializeComponent();
        }

        private void m_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void Point_Button_Click(object sender, EventArgs e)
        {

        }


        private void Pi_Button_Click(object sender, EventArgs e)
        {

        }

        private void Text_Output_Screen(object sender, EventArgs e)
        {

        }

        private void NumberButton(object sender, EventArgs e)
        {
            if ((Text_Output.Text == "0") || Mono_OperationPerformed) 
                Text_Output.Clear();
            
            Mono_OperationPerformed = false;
            Button button = (Button)sender;

            //function needed for the single used of dot button (.)

            if (button.Text == ".")  
            {
                if (!Text_Output.Text.Contains("."))
                    Text_Output.Text = Text_Output.Text + button.Text;
            }
            else
            Text_Output.Text = Text_Output.Text + button.Text;

        }

        private void Operator_Click(object sender, EventArgs e)

        //Parse is used to Converts the string representation of a number
        //in a specified style and culture-specific format to its double-precision 
        //floating-point number equivalent.

        {
            Button button = (Button)sender;
            Mono_Operation = button.Text;
            Mono_Result = Double.Parse(Text_Output.Text);
            Mono_OperationPerformed = true;

        }
        private void Clear_Button_Click(object sender, EventArgs e)

            //Function for C button

        {
            Text_Output.Text = "0";
            Mono_Result = 0;
        }
        private void Equal_Button_Click(object sender, EventArgs e)

            //Function for operation buttons 
        {
            switch(Mono_Operation)
            {
                case "+":
                    Text_Output.Text = (Mono_Result + Double.Parse(Text_Output.Text)).ToString();
                    break;
                case "-":
                    Text_Output.Text = (Mono_Result - Double.Parse(Text_Output.Text)).ToString();
                    break;
                case "*":
                    Text_Output.Text = (Mono_Result * Double.Parse(Text_Output.Text)).ToString();
                    break;
                case "/":
                    Text_Output.Text = (Mono_Result / Double.Parse(Text_Output.Text)).ToString();
                    break;
                default:
                    break;
            }
        }
    }
}
