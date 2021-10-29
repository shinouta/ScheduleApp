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
    /// Window1.xaml の相互作用ロジック
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }



        private void Button_cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_ok_Click(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.ZoomUrl = ZoomText.Text;
            Properties.Settings.Default.ZoomHours = (int)HoursText.Value;
            Properties.Settings.Default.ZoomMinutes = (int)MinutesText.Value;

            if(Properties.Settings.Default.ZoomUrl == "")
            {
                Properties.Settings.Default.ZoomOnOff = false;
                MessageBox.Show("ZoomURLを入力してください。");
            }
            else
            {
                Properties.Settings.Default.ZoomOnOff = true;
                MessageBox.Show("正常に予約できました。");
                this.Close();
            }


        }

        private void Window_ContentRendered(object sender, EventArgs e)
        {
            ZoomText.Text = Properties.Settings.Default.ZoomUrl;
            HoursText.Value = Properties.Settings.Default.ZoomHours;
            MinutesText.Value = Properties.Settings.Default.ZoomMinutes;
        }

        private void alarmOn_Checked(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.ZoomOnOff = true;
        }

        private void alarmOff_Checked(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.ZoomOnOff = false;
        }
    }
}
