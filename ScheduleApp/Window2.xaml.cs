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
    /// Window2.xaml の相互作用ロジック
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

        private void Button2_ok_Click(object sender, RoutedEventArgs e)
        {
            if (ZoomDay.Text == ""
                | ClassText.Text == "")
            {
                MessageBox.Show("必要な項目が入力されていません。");
            }
            else
            {
                if (ZoomDay.Text == "月" && ClassText.Text == "1")
                {
                    Properties.Settings.Default.ZoomURL1_1 = ZoomText2.Text;
                    Properties.Settings.Default.LectureName1_1 = LectureText.Text;
                }

                if (ZoomDay.Text == "月" && ClassText.Text == "2")
                {
                    Properties.Settings.Default.ZoomURL1_2 = ZoomText2.Text;
                    Properties.Settings.Default.LectureName1_2 = LectureText.Text;
                }

                if (ZoomDay.Text == "月" && ClassText.Text == "3")
                {
                    Properties.Settings.Default.ZoomURL1_3 = ZoomText2.Text;
                    Properties.Settings.Default.LectureName1_3 = LectureText.Text;
                }

                if (ZoomDay.Text == "月" && ClassText.Text == "4")
                {
                    Properties.Settings.Default.ZoomURL1_4 = ZoomText2.Text;
                    Properties.Settings.Default.LectureName1_4 = LectureText.Text;
                }

                if (ZoomDay.Text == "月" && ClassText.Text == "5")
                {
                    Properties.Settings.Default.ZoomURL1_5 = ZoomText2.Text;
                    Properties.Settings.Default.LectureName1_5 = LectureText.Text;
                }

                if (ZoomDay.Text == "火" && ClassText.Text == "1")
                {
                    Properties.Settings.Default.ZoomURL2_1 = ZoomText2.Text;
                    Properties.Settings.Default.LectureName2_1 = LectureText.Text;
                }

                if (ZoomDay.Text == "火" && ClassText.Text == "2")
                {
                    Properties.Settings.Default.ZoomURL2_2 = ZoomText2.Text;
                    Properties.Settings.Default.LectureName2_2 = LectureText.Text;
                }

                if (ZoomDay.Text == "火" && ClassText.Text == "3")
                {
                    Properties.Settings.Default.ZoomURL2_3 = ZoomText2.Text;
                    Properties.Settings.Default.LectureName2_3 = LectureText.Text;
                }

                if (ZoomDay.Text == "火" && ClassText.Text == "4")
                {
                    Properties.Settings.Default.ZoomURL2_4 = ZoomText2.Text;
                    Properties.Settings.Default.LectureName2_4 = LectureText.Text;
                }

                if (ZoomDay.Text == "火" && ClassText.Text == "5")
                {
                    Properties.Settings.Default.ZoomURL2_5 = ZoomText2.Text;
                    Properties.Settings.Default.LectureName2_5 = LectureText.Text;
                }

                if (ZoomDay.Text == "水" && ClassText.Text == "1")
                {
                    Properties.Settings.Default.ZoomURL3_1 = ZoomText2.Text;
                    Properties.Settings.Default.LectureName3_1 = LectureText.Text;
                }

                if (ZoomDay.Text == "水" && ClassText.Text == "2")
                {
                    Properties.Settings.Default.ZoomURL3_2 = ZoomText2.Text;
                    Properties.Settings.Default.LectureName3_2 = LectureText.Text;
                }

                if (ZoomDay.Text == "水" && ClassText.Text == "3")
                {
                    Properties.Settings.Default.ZoomURL3_3 = ZoomText2.Text;
                    Properties.Settings.Default.LectureName3_3 = LectureText.Text;
                }

                if (ZoomDay.Text == "水" && ClassText.Text == "4")
                {
                    Properties.Settings.Default.ZoomURL3_4 = ZoomText2.Text;
                    Properties.Settings.Default.LectureName3_4 = LectureText.Text;
                }

                if (ZoomDay.Text == "水" && ClassText.Text == "5")
                {
                    Properties.Settings.Default.ZoomURL3_5 = ZoomText2.Text;
                    Properties.Settings.Default.LectureName3_5 = LectureText.Text;
                }

                if (ZoomDay.Text == "木" && ClassText.Text == "1")
                {
                    Properties.Settings.Default.ZoomURL4_1 = ZoomText2.Text;
                    Properties.Settings.Default.LectureName4_1 = LectureText.Text;
                }

                if (ZoomDay.Text == "木" && ClassText.Text == "2")
                {
                    Properties.Settings.Default.ZoomURL4_2 = ZoomText2.Text;
                    Properties.Settings.Default.LectureName4_2 = LectureText.Text;
                }

                if (ZoomDay.Text == "木" && ClassText.Text == "3")
                {
                    Properties.Settings.Default.ZoomURL4_3 = ZoomText2.Text;
                    Properties.Settings.Default.LectureName4_3 = LectureText.Text;
                }

                if (ZoomDay.Text == "木" && ClassText.Text == "4")
                {
                    Properties.Settings.Default.ZoomURL4_4 = ZoomText2.Text;
                    Properties.Settings.Default.LectureName4_4 = LectureText.Text;
                }

                if (ZoomDay.Text == "木" && ClassText.Text == "5")
                {
                    Properties.Settings.Default.ZoomURL4_5 = ZoomText2.Text;
                    Properties.Settings.Default.LectureName4_5 = LectureText.Text;
                }

                if (ZoomDay.Text == "金" && ClassText.Text == "1")
                {
                    Properties.Settings.Default.ZoomURL5_1 = ZoomText2.Text;
                    Properties.Settings.Default.LectureName5_1 = LectureText.Text;
                }

                if (ZoomDay.Text == "金" && ClassText.Text == "2")
                {
                    Properties.Settings.Default.ZoomURL5_2 = ZoomText2.Text;
                    Properties.Settings.Default.LectureName5_2 = LectureText.Text;
                }

                if (ZoomDay.Text == "金" && ClassText.Text == "3")
                {
                    Properties.Settings.Default.ZoomURL5_3 = ZoomText2.Text;
                    Properties.Settings.Default.LectureName5_3 = LectureText.Text;
                }

                if (ZoomDay.Text == "金" && ClassText.Text == "4")
                {
                    Properties.Settings.Default.ZoomURL5_4 = ZoomText2.Text;
                    Properties.Settings.Default.LectureName5_4 = LectureText.Text;
                }

                if (ZoomDay.Text == "金" && ClassText.Text == "5")
                {
                    Properties.Settings.Default.ZoomURL5_5 = ZoomText2.Text;
                    Properties.Settings.Default.LectureName5_5 = LectureText.Text;
                }

                Properties.Settings.Default.Save();
                var window0 = new MainWindow();
                window0.Show();
                this.Close();
            }
        }

        private void Button2_cancel_Click(object sender, RoutedEventArgs e)
        {
            var window0 = new MainWindow();
            window0.Show();
            this.Close();
        }
    }
}
