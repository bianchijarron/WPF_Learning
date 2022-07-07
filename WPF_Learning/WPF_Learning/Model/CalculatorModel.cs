using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Learning.Model
{
    public class CalculatorModel
    {
        public CalculatorModel()
        {
            A = "";
            B = "";
            operatorSign = "";
            Display = "";
        }
        public string A;
        public string B;
        public string operatorSign;
        public string Display;
        public double result;
    }
}
