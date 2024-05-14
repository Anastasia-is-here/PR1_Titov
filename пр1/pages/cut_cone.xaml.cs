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
    /// Логика взаимодействия для cut_cone.xaml
    /// </summary>
    public partial class cut_cone : Page
    {
        MainWindow win = (MainWindow)Application.Current.MainWindow;
        public cut_cone()
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
            double R, r, H, S_side, S_general, V, L;



            if (double.TryParse(Radius.Text, out R) && (double.TryParse(Height.Text, out H) && (double.TryParse(radius.Text, out r))))
            {
                V = (1 / 3) * Math.PI * H * (Math.Pow(r, 2) + r * R + Math.Pow(R, 2));
                Volume.Text = Convert.ToString(V);


                L = Math.Sqrt(Math.Pow(R, 2) + Math.Pow(H, 2));
                S_side = 1/3 * Math.PI * L * (r + R);
                Side.Text = Convert.ToString(S_side);

                S_general = Math.PI * (Math.Pow(r, 2) + (r + R) * L + Math.Pow(R, 2));
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
