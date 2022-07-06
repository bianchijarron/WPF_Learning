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
    /// simple_2.xaml 的互動邏輯
    /// </summary>
    public partial class simple_2 : Window
    {
        public simple_2()
        {
            InitializeComponent();
        }

        int count = 0;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            count++;
            label_01.Content = $"clicl {count} times";
        }
    }
}
