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
    /// simple_10.xaml 的互動邏輯
    /// </summary>
    public partial class simple_10 : Window
    {
        public simple_10()
        {
            InitializeComponent();
        }

        bool if_mouse_down = false;
        Point last_point;

        private void Canvas_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if_mouse_down = true;
            last_point = e.GetPosition(this);
            //MessageBox.Show(e.GetPosition(this).X.ToString() + "," + e.GetPosition(this).Y.ToString());
        }

        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (if_mouse_down)
            {
                Point thisPoint = e.GetPosition(this);
                canvas.Children.Add(new Line() { X1 = last_point.X, Y1 = last_point.Y, X2 = thisPoint.X, Y2 = thisPoint.Y, Stroke = Brushes.Black });
                last_point = thisPoint;
            }
        }

        private void Canvas_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if_mouse_down = false;
        }
    }
}
