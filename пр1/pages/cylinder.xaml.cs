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
using System.Windows.Threading;

namespace пр1.pages
{
    /// <summary>
    /// Логика взаимодействия для cylinder.xaml
    /// </summary>
    public partial class cylinder : Page
    {
        MainWindow win = (MainWindow)Application.Current.MainWindow;
        public cylinder()
        {
            InitializeComponent();
        }
        private void back_MouseUp(object sender, MouseButtonEventArgs e)
        {
            var timer = new DispatcherTimer { Interval = TimeSpan.FromSeconds(0.3) };
            timer.Start();
            timer.Tick += (send, args) =>
            {
                timer.Stop();
                Application.Current.Dispatcher.Invoke(() =>
                {
                    win.main.Navigate(new menu());
                });


            };
        }
        private void BtnCalc_Click(object sender, RoutedEventArgs e)
        {
            double R, H, S_side, S_general, V;



            if (double.TryParse(Radius.Text, out R) && (double.TryParse(Height.Text, out H)))
            {
                V = Math.PI * Math.Pow(R, 2) * H;
                Volume.Text = Convert.ToString(V);

                S_side = Math.PI * R * H;
                Side.Text = Convert.ToString(S_side);

                S_general = 2 * Math.PI * Math.Pow(R, 2) + S_side;
                S_gen.Text = Convert.ToString(S_general);

            }
            else { MessageBox.Show("Проверьте ввод"); }
        }
        private void exit_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var timer = new DispatcherTimer { Interval = TimeSpan.FromSeconds(0.3) };
            timer.Start();
            timer.Tick += (send, args) =>
            {
                timer.Stop();
                Application.Current.Dispatcher.Invoke(() =>
                {
                    var res = MessageBox.Show("Вы уверены, что хотите закрыть программу?", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question);
                    if (res == MessageBoxResult.Yes)
                    {
                        win.Close();
                        return;
                    }
                    else
                    {
                        win.Close();
                        return;
                    }
                });


            };
        }
        }
}
