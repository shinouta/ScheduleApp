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


namespace ScheduleApp
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        private DispatcherTimer timer;
        public MainWindow()
        {
            InitializeComponent();
            timer = CreateTimer();
            timer.Start();
        }

        private DispatcherTimer CreateTimer()
        {
            var t = new DispatcherTimer(DispatcherPriority.SystemIdle);
            t.Interval = TimeSpan.FromMilliseconds(1000);
            t.Tick += (sender, e) =>
            {
                DateTime now = DateTime.Now;

                if (Properties.Settings.Default.ZoomHours == now.Hour
                && Properties.Settings.Default.ZoomMinutes == now.Minute
                && Properties.Settings.Default.ZoomOnOff == true)
                {
                    Properties.Settings.Default.ZoomOnOff = false;
                    System.Diagnostics.Process.Start(@"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", Properties.Settings.Default.ZoomUrl);
                }
            };

            return t;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var window1 = new Window1();
            window1.Show();
        }


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var window2 = new Window2();
            window2.Show();
            this.Close();
        }

        private void Window_ContentRendered(object sender, EventArgs e)
        {
            Button1_1.Content = Properties.Settings.Default.LectureName1_1;
            Button1_2.Content = Properties.Settings.Default.LectureName1_2;
            Button1_3.Content = Properties.Settings.Default.LectureName1_3;
            Button1_4.Content = Properties.Settings.Default.LectureName1_4;
            Button1_5.Content = Properties.Settings.Default.LectureName1_5;

            Button2_1.Content = Properties.Settings.Default.LectureName2_1;
            Button2_2.Content = Properties.Settings.Default.LectureName2_2;
            Button2_3.Content = Properties.Settings.Default.LectureName2_3;
            Button2_4.Content = Properties.Settings.Default.LectureName2_4;
            Button2_5.Content = Properties.Settings.Default.LectureName2_5;

            Button3_1.Content = Properties.Settings.Default.LectureName3_1;
            Button3_2.Content = Properties.Settings.Default.LectureName3_2;
            Button3_3.Content = Properties.Settings.Default.LectureName3_3;
            Button3_4.Content = Properties.Settings.Default.LectureName3_4;
            Button3_5.Content = Properties.Settings.Default.LectureName3_5;

            Button4_1.Content = Properties.Settings.Default.LectureName4_1;
            Button4_2.Content = Properties.Settings.Default.LectureName4_2;
            Button4_3.Content = Properties.Settings.Default.LectureName4_3;
            Button4_4.Content = Properties.Settings.Default.LectureName4_4;
            Button4_5.Content = Properties.Settings.Default.LectureName4_5;

            Button5_1.Content = Properties.Settings.Default.LectureName5_1;
            Button5_2.Content = Properties.Settings.Default.LectureName5_2;
            Button5_3.Content = Properties.Settings.Default.LectureName5_3;
            Button5_4.Content = Properties.Settings.Default.LectureName5_4;
            Button5_5.Content = Properties.Settings.Default.LectureName5_5;

            time1_0_h.Text = Properties.Settings.Default.Time1_0_h;
            time1_0_m.Text = Properties.Settings.Default.Time1_0_m;
            time1_1_h.Text = Properties.Settings.Default.Time1_1_h;
            time1_1_m.Text = Properties.Settings.Default.Time1_1_m;
            
            time2_0_h.Text = Properties.Settings.Default.Time2_0_h;
            time2_0_m.Text = Properties.Settings.Default.Time2_0_m;
            time2_1_h.Text = Properties.Settings.Default.Time2_1_h;
            time2_1_m.Text = Properties.Settings.Default.Time2_1_m;
            
            time3_0_h.Text = Properties.Settings.Default.Time3_0_h;
            time3_0_m.Text = Properties.Settings.Default.Time3_0_m;
            time3_1_h.Text = Properties.Settings.Default.Time3_1_h;
            time3_1_m.Text = Properties.Settings.Default.Time3_1_m;
            
            time4_0_h.Text = Properties.Settings.Default.Time4_0_h;
            time4_0_m.Text = Properties.Settings.Default.Time4_0_m;
            time4_1_h.Text = Properties.Settings.Default.Time4_1_h;
            time4_1_m.Text = Properties.Settings.Default.Time4_1_m;
            
            time5_0_h.Text = Properties.Settings.Default.Time5_0_h;
            time5_0_m.Text = Properties.Settings.Default.Time5_0_m;
            time5_1_h.Text = Properties.Settings.Default.Time5_1_h;
            time5_1_m.Text = Properties.Settings.Default.Time5_1_m;
        }

        private void Button1_1_Click(object sender, RoutedEventArgs e)
        {
            if (Properties.Settings.Default.LectureName1_1 != "" & Properties.Settings.Default.ZoomURL1_1 != "")
            {
                System.Diagnostics.Process.Start(@"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", Properties.Settings.Default.ZoomURL1_1);
                this.Close();
            }
        }

        private void Button1_2_Click(object sender, RoutedEventArgs e)
        {
            if (Properties.Settings.Default.LectureName1_2 != "" & Properties.Settings.Default.ZoomURL1_2 != "")
            {
                System.Diagnostics.Process.Start(@"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", Properties.Settings.Default.ZoomURL1_2);
                this.Close();
            }
        }

        private void Button1_3_Click(object sender, RoutedEventArgs e)
        {
            if (Properties.Settings.Default.LectureName1_3 != "" & Properties.Settings.Default.ZoomURL1_3 != "")
            {
                System.Diagnostics.Process.Start(@"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", Properties.Settings.Default.ZoomURL1_3);
                this.Close();
            }
        }

        private void Button1_4_Click(object sender, RoutedEventArgs e)
        {
            if (Properties.Settings.Default.LectureName1_4 != "" & Properties.Settings.Default.ZoomURL1_4 != "")
            {
                System.Diagnostics.Process.Start(@"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", Properties.Settings.Default.ZoomURL1_4);
                this.Close();
            }
        }

        private void Button1_5_Click(object sender, RoutedEventArgs e)
        {
            if (Properties.Settings.Default.LectureName1_5 != "" & Properties.Settings.Default.ZoomURL1_5 != "")
            {
                System.Diagnostics.Process.Start(@"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", Properties.Settings.Default.ZoomURL1_5);
                this.Close();
            }
        }

        private void Button2_1_Click(object sender, RoutedEventArgs e)
        {
            if (Properties.Settings.Default.LectureName2_1 != "" & Properties.Settings.Default.ZoomURL2_1 != "")
            {
                System.Diagnostics.Process.Start(@"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", Properties.Settings.Default.ZoomURL2_1);
                this.Close();
            }
        }

        private void Button2_2_Click(object sender, RoutedEventArgs e)
        {
            if (Properties.Settings.Default.LectureName2_2 != "" & Properties.Settings.Default.ZoomURL2_2 != "")
            {
                System.Diagnostics.Process.Start(@"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", Properties.Settings.Default.ZoomURL2_2);
                this.Close();
            }
        }

        private void Button2_3_Click(object sender, RoutedEventArgs e)
        {
            if (Properties.Settings.Default.LectureName2_3 != "" & Properties.Settings.Default.ZoomURL2_3 != "")
            {
                System.Diagnostics.Process.Start(@"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", Properties.Settings.Default.ZoomURL2_3);
                this.Close();
            }
        }

        private void Button2_4_Click(object sender, RoutedEventArgs e)
        {
            if (Properties.Settings.Default.LectureName2_4 != "" & Properties.Settings.Default.ZoomURL2_4 != "")
            {
                System.Diagnostics.Process.Start(@"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", Properties.Settings.Default.ZoomURL2_4);
                this.Close();
            }
        }

        private void Button2_5_Click(object sender, RoutedEventArgs e)
        {
            if (Properties.Settings.Default.LectureName2_5 != "" & Properties.Settings.Default.ZoomURL2_5 != "")
            {
                System.Diagnostics.Process.Start(@"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", Properties.Settings.Default.ZoomURL2_5);
                this.Close();
            }
        }

        private void Button3_1_Click(object sender, RoutedEventArgs e)
        {
            if (Properties.Settings.Default.LectureName3_1 != "" & Properties.Settings.Default.ZoomURL3_1 != "")
            {
                System.Diagnostics.Process.Start(@"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", Properties.Settings.Default.ZoomURL3_1);
                this.Close();
            }
        }

        private void Button3_2_Click(object sender, RoutedEventArgs e)
        {
            if (Properties.Settings.Default.LectureName3_2 != "" & Properties.Settings.Default.ZoomURL3_2 != "")
            {
                System.Diagnostics.Process.Start(@"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", Properties.Settings.Default.ZoomURL3_2);
                this.Close();
            }
        }

        private void Button3_3_Click(object sender, RoutedEventArgs e)
        {
            if (Properties.Settings.Default.LectureName3_3 != "" & Properties.Settings.Default.ZoomURL3_3 != "")
            {
                System.Diagnostics.Process.Start(@"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", Properties.Settings.Default.ZoomURL3_3);
                this.Close();
            }
        }

        private void Button3_4_Click(object sender, RoutedEventArgs e)
        {
            if (Properties.Settings.Default.LectureName3_4 != "" & Properties.Settings.Default.ZoomURL3_4 != "")
            {
                System.Diagnostics.Process.Start(@"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", Properties.Settings.Default.ZoomURL3_4);
                this.Close();
            }
        }

        private void Button3_5_Click(object sender, RoutedEventArgs e)
        {
            if (Properties.Settings.Default.LectureName3_5 != "" & Properties.Settings.Default.ZoomURL3_5 != "")
            {
                System.Diagnostics.Process.Start(@"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", Properties.Settings.Default.ZoomURL3_5);
                this.Close();
            }
        }

        private void Button4_1_Click(object sender, RoutedEventArgs e)
        {
            if (Properties.Settings.Default.LectureName4_1 != "" & Properties.Settings.Default.ZoomURL4_1 != "")
            {
                System.Diagnostics.Process.Start(@"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", Properties.Settings.Default.ZoomURL4_1);
                this.Close();
            }
        }

        private void Button4_2_Click(object sender, RoutedEventArgs e)
        {
            if (Properties.Settings.Default.LectureName4_2 != "" & Properties.Settings.Default.ZoomURL4_2 != "")
            {
                System.Diagnostics.Process.Start(@"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", Properties.Settings.Default.ZoomURL4_2);
                this.Close();
            }
        }

        private void Button4_3_Click(object sender, RoutedEventArgs e)
        {
            if (Properties.Settings.Default.LectureName4_3 != "" & Properties.Settings.Default.ZoomURL4_3 != "")
            {
                System.Diagnostics.Process.Start(@"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", Properties.Settings.Default.ZoomURL4_3);
                this.Close();
            }
        }

        private void Button4_4_Click(object sender, RoutedEventArgs e)
        {
            if (Properties.Settings.Default.LectureName4_4 != "" & Properties.Settings.Default.ZoomURL4_4 != "")
            {
                System.Diagnostics.Process.Start(@"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", Properties.Settings.Default.ZoomURL4_4);
                this.Close();
            }
        }

        private void Button4_5_Click(object sender, RoutedEventArgs e)
        {
            if (Properties.Settings.Default.LectureName4_5 != "" & Properties.Settings.Default.ZoomURL4_5 != "")
            {
                System.Diagnostics.Process.Start(@"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", Properties.Settings.Default.ZoomURL4_5);
                this.Close();
            }
        }

        private void Button5_1_Click(object sender, RoutedEventArgs e)
        {
            if (Properties.Settings.Default.LectureName5_1 != "" & Properties.Settings.Default.ZoomURL5_1 != "")
            {
                System.Diagnostics.Process.Start(@"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", Properties.Settings.Default.ZoomURL5_1);
                this.Close();
            }
        }

        private void Button5_2_Click(object sender, RoutedEventArgs e)
        {
            if (Properties.Settings.Default.LectureName5_2 != "" & Properties.Settings.Default.ZoomURL5_2 != "")
            {
                System.Diagnostics.Process.Start(@"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", Properties.Settings.Default.ZoomURL5_2);
                this.Close();
            }
        }

        private void Button5_3_Click(object sender, RoutedEventArgs e)
        {
            if (Properties.Settings.Default.LectureName5_3 != "" & Properties.Settings.Default.ZoomURL5_3 != "")
            {
                System.Diagnostics.Process.Start(@"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", Properties.Settings.Default.ZoomURL5_3);
                this.Close();
            }
        }

        private void Button5_4_Click(object sender, RoutedEventArgs e)
        {
            if (Properties.Settings.Default.LectureName5_4 != "" & Properties.Settings.Default.ZoomURL5_4 != "")
            {
                System.Diagnostics.Process.Start(@"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", Properties.Settings.Default.ZoomURL5_4);
                this.Close();
            }
        }

        private void Button5_5_Click(object sender, RoutedEventArgs e)
        {
            if (Properties.Settings.Default.LectureName5_5 != "" & Properties.Settings.Default.ZoomURL5_5 != "")
            {
                System.Diagnostics.Process.Start(@"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", Properties.Settings.Default.ZoomURL5_5);
                this.Close();
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var window3 = new Window3();
            window3.Show();
            this.Close();
        }
    }
}
