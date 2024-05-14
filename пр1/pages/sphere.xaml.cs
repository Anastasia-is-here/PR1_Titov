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
    /// Логика взаимодействия для sphere.xaml
    /// </summary>
    public partial class sphere : Page
    {
        MainWindow win = (MainWindow)Application.Current.MainWindow;
        
        public sphere()
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
            double R, V, S;
            if (double.TryParse(Radius.Text, out R))
            {
                V = (4.0 / 3.0) * Math.PI * Math.Pow(R, 3);
                Volume.Text = Convert.ToString(V);
                Volume.TextDecorations = TextDecorations.Underline;

                S = 4 * Math.PI * Math.Pow(R, 2);
                Area.Text = Convert.ToString(S);
                Area.TextDecorations = TextDecorations.Underline;
            }
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

 