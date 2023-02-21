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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Wpf_task_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Random rnd = new Random();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Btn1_Click(object sender, RoutedEventArgs e)
        {
            Random r = new Random();
            Brush brush = new SolidColorBrush(Color.FromRgb((byte)r.Next(1, 255),
                              (byte)r.Next(1, 255), (byte)r.Next(1, 233)));
            if (sender is Button btn)
            {
                btn.Background = brush;
                MessageBox.Show($"{btn.Name} clicked");
            }
        }

        private void Btn1_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (sender is Button btn)
            {
                Grid1.Children.Remove(btn);
                this.Title = $"Button " + btn.Content as string + $" deleted";
            }
        }
    }
}
