using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
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


namespace project_week_2
{

    /// <summary>
    /// Interaction logic for aboutpage.xaml
    /// </summary>
    public partial class aboutpage : Window
    {

        public aboutpage()
        {
            InitializeComponent();
        }

        private void guid_Click(object sender, RoutedEventArgs e)
        {
            guide g = new guide();
            g.Show();
            this.Close();
        }

        private void home_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            this.Close();
        }

        private void about_Click(object sender, RoutedEventArgs e)
        {
            aboutpage ap = new aboutpage();
            ap.Show();
            this.Close();
        }


    }
}
