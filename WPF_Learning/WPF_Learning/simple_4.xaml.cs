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
    /// simple_4.xaml 的互動邏輯
    /// </summary>
    public partial class simple_4 : Window
    {
        public simple_4()
        {
            InitializeComponent();
            timer.Interval = new TimeSpan(10000);
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            p_bar.Value++;
            if (p_bar.Value > 100)
                timer.Stop();
        }



        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //p_bar.Value = 50;
            timer.Start();
        }

        System.Windows.Threading.DispatcherTimer timer = new System.Windows.Threading.DispatcherTimer();
    }
}
