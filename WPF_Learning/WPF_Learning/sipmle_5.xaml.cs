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
    /// sipmle_5.xaml 的互動邏輯
    /// </summary>
    public partial class sipmle_5 : Window
    {
        public sipmle_5()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show(datatimepicker1.SelectedDateTime.ToString());
            HandyControl.Controls.Dialog.Show(new dialog(datatimepicker1.SelectedDateTime.ToString()));
        }
    }
}
