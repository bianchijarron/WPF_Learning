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

namespace WPF_Learning.View
{
    /// <summary>
    /// step1.xaml 的互動邏輯
    /// </summary>
    public partial class step1 : Window
    {
        ViewModel.MRTStationVM vm = new ViewModel.MRTStationVM();//新建一個 MRTStationVM()，讓他執行 MRTStationVM()底下程式把樓層資訊抓近來
        public step1()
        {
            InitializeComponent();
            this.DataContext = vm;//把東西塞到畫面上
        }

        private void CheckComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            foreach (ViewModel.MRTLevelVM item in (sender as HandyControl.Controls.CheckComboBox).Items)
            {
                item.selected = false;
            }

            foreach (ViewModel.MRTLevelVM item in (sender as HandyControl.Controls.CheckComboBox).SelectedItems)
            {
                item.selected = true;
            }

            input_refresh();
        }

        void input_refresh()
        {
            level_input.Children.Clear();
            foreach (var level in vm.Levels)
            {
                if (level.selected)
                {
                    StackPanel panel = new StackPanel();
                    panel.Orientation = Orientation.Horizontal;
                    panel.Children.Add(new Label { Content = level.name, BorderBrush = Brushes.Transparent });
                    TextBox tb = new TextBox { Text = level.height.ToString(), Width = 100, TextAlignment = TextAlignment.Right, Tag = level.index };
                    tb.TextChanged += Tb_TextChanged;
                    panel.Children.Add(tb);
                    panel.Children.Add(new Label { Content = "m", BorderBrush = Brushes.Transparent });
                    level_input.Children.Add(panel);
                }
            }
        }

        private void Tb_TextChanged(object sender, TextChangedEventArgs e)
        {
            vm.Levels[(int)(sender as TextBox).Tag].height = Convert.ToDouble((sender as TextBox).Text);
        }
    }
}
