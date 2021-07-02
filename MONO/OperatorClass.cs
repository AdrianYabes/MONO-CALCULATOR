using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MONO
{
    class OperatorClass
    {
        private String mono_Operation = "";
        private String num1 = "";
        private String num2 = "";
        private bool mono_OperationPerformed = false;
        public string Mono_Operation { get => mono_Operation; set => mono_Operation = value; }
        public string Num1 { get => num1; set => num1 = value; }
        public bool Mono_OperationPerformed { get => mono_OperationPerformed; set => mono_OperationPerformed = value; }
        public string Num2 { get => num2; set => num2 = value; }
        public void Addition()
        {
            Num2 = (Double.Parse(Num1) + Double.Parse(Num2)).ToString();
        }
        public void Subtraction()
        {
            Num2 = (Double.Parse(Num1) - Double.Parse(Num2)).ToString();
        }
        public void Multiplication()
        {
            Num2 = (Double.Parse(Num1) * Double.Parse(Num2)).ToString();
        }
        public void Division()
        {
            Num2 = (Double.Parse(Num1) / Double.Parse(Num2)).ToString();
        }
    }
}