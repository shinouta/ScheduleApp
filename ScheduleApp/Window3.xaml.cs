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

namespace ScheduleApp
{
    /// <summary>
    /// Window3.xaml の相互作用ロジック
    /// </summary>
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();
        }

        private void Button2_ok_Click(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.Time1_0_h = time1_0_h.Text.PadLeft(2, '0');
            Properties.Settings.Default.Time1_0_m = time1_0_m.Text.PadLeft(2, '0');
            Properties.Settings.Default.Time1_1_h = time1_1_h.Text.PadLeft(2, '0');
            Properties.Settings.Default.Time1_1_m = time1_1_m.Text.PadLeft(2, '0');

            Properties.Settings.Default.Time2_0_h = time2_0_h.Text.PadLeft(2, '0');
            Properties.Settings.Default.Time2_0_m = time2_0_m.Text.PadLeft(2, '0');
            Properties.Settings.Default.Time2_1_h = time2_1_h.Text.PadLeft(2, '0');
            Properties.Settings.Default.Time2_1_m = time2_1_m.Text.PadLeft(2, '0');

            Properties.Settings.Default.Time3_0_h = time3_0_h.Text.PadLeft(2, '0');
            Properties.Settings.Default.Time3_0_m = time3_0_m.Text.PadLeft(2, '0');
            Properties.Settings.Default.Time3_1_h = time3_1_h.Text.PadLeft(2, '0');
            Properties.Settings.Default.Time3_1_m = time3_1_m.Text.PadLeft(2, '0');

            Properties.Settings.Default.Time4_0_h = time4_0_h.Text.PadLeft(2, '0');
            Properties.Settings.Default.Time4_0_m = time4_0_m.Text.PadLeft(2, '0');
            Properties.Settings.Default.Time4_1_h = time4_1_h.Text.PadLeft(2, '0');
            Properties.Settings.Default.Time4_1_m = time4_1_m.Text.PadLeft(2, '0');

            Properties.Settings.Default.Time5_0_h = time5_0_h.Text.PadLeft(2, '0');
            Properties.Settings.Default.Time5_0_m = time5_0_m.Text.PadLeft(2, '0');
            Properties.Settings.Default.Time5_1_h = time5_1_h.Text.PadLeft(2, '0');
            Properties.Settings.Default.Time5_1_m = time5_1_m.Text.PadLeft(2, '0');

            Properties.Settings.Default.Save();
            var window0 = new MainWindow();
            window0.Show();
            this.Close();

        }

        private void Button2_cancel_Click(object sender, RoutedEventArgs e)
        {
            var window0 = new MainWindow();
            window0.Show();
            this.Close();
        }

        private void Window_ContentRendered(object sender, EventArgs e)
        {
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
    }
}
