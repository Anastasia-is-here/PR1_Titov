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
    /// Логика взаимодействия для menu.xaml
    /// </summary>
    public partial class menu : Page
    {
        MainWindow win = (MainWindow)Application.Current.MainWindow;

        public menu()
        {
            InitializeComponent();

        }

        private void Sphere_MouseUp(object sender, MouseButtonEventArgs e)
        {
            
            var timer = new DispatcherTimer { Interval = TimeSpan.FromSeconds(0.3) };
            timer.Start();
            timer.Tick += (send, args) =>
            {
                timer.Stop();
                Application.Current.Dispatcher.Invoke(() =>
                {
                    win.main.Navigate(new sphere());
                });
                
                
            };
            
        }

        private void cone_MouseUp(object sender, MouseButtonEventArgs e)
        {
            var timer = new DispatcherTimer { Interval = TimeSpan.FromSeconds(0.3) };
            timer.Start();
            timer.Tick += (send, args) =>
            {
                timer.Stop();
                Application.Current.Dispatcher.Invoke(() =>
                {
                    win.main.Navigate(new cone());
                });
            };
        }

        private void cylinder_MouseUp(object sender, MouseButtonEventArgs e)
        {
            var timer = new DispatcherTimer { Interval = TimeSpan.FromSeconds(0.3) };
            timer.Start();
            timer.Tick += (send, args) =>
            {
                timer.Stop();
                Application.Current.Dispatcher.Invoke(() =>
                {
                    win.main.Navigate(new cylinder());
                });
            };
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

        private void cut_cylinder_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var timer = new DispatcherTimer { Interval = TimeSpan.FromSeconds(0.3) };
            timer.Start();
            timer.Tick += (send, args) =>
            {
                timer.Stop();
                Application.Current.Dispatcher.Invoke(() =>
                {
                    win.main.Navigate(new cut_cone());
                });
            };
        }
    }
}
