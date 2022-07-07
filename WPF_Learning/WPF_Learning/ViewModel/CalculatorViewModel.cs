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
    }
}
