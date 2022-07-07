using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Learning.ViewModel
{
    public class CalculatorViewModel:ViewModelBase
    {
        private Model.CalculatorModel calcModel;
        public CalculatorViewModel()
        {
            calcModel = new Model.CalculatorModel();
        }

        public string A
        {
            get { return calcModel.A;}
            set
            {
                calcModel.A = value;
                OnPropertyChanged();
            }
        }

        public string B
        {
            get { return calcModel.B; }
            set
            {
                calcModel.B = value;
                OnPropertyChanged();
            }
        }

        public string operatorSign
        {
            get { return calcModel.operatorSign; }
            set
            {
                calcModel.operatorSign = value;
                OnPropertyChanged();
            }
        }

        public string Display
        {
            get { return calcModel.Display; }
            set
            {
                calcModel.Display = value;
                OnPropertyChanged();
            }
        }

        public double result
        {
            get
            {
                double _a = Convert.ToDouble(calcModel.A == "" ? "0" : calcModel.A);
                double _b = Convert.ToDouble(calcModel.B == "" ? "0" : calcModel.B);

                if(calcModel.operatorSign == "+")
                    return _a + _b;
                else if (calcModel.operatorSign == "-")
                    return _a - _b;
                if (calcModel.operatorSign == "*")
                    return _a * _b;
                if (calcModel.operatorSign == "/")
                    return _a / _b;
                else
                    return 0;
            }
        }
    }
}
