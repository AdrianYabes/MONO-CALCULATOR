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
            if (Text_Output.Text == "0") 
            {
                Text_Output.Clear();
            }
            Button button = (Button)sender;
            Text_Output.Text = Text_Output.Text + button.Text;

        }

        private void Operator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Mono_Operation = button.Text;
            Mono_Result = Double.Parse(Text_Output.Text);

        }
        private void Clear_Button_Click(object sender, EventArgs e)
        {
            Text_Output.Text = "0";
            Mono_Result = 0;
        }
        private void Equal_Button_Click(object sender, EventArgs e)
        {

        }
    }
}
