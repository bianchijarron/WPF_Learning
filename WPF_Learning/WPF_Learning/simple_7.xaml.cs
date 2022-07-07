using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPF_Learning
{
    /// <summary>
    /// simple_7.xaml 的互動邏輯
    /// </summary>
    public partial class simple_7 : Window
    {
        public simple_7()
        {
            InitializeComponent();

            Binding binding = new Binding("Value");
            binding.Source = silder1;
            pbar1.SetBinding(ProgressBar.ValueProperty, binding);
        }
    }
}
