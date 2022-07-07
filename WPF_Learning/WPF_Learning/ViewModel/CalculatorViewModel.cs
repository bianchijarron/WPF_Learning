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
    }
}
