using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace project_week_2
{
    /// <summary>
    /// Interaction logic for Vraag.xaml
    /// </summary>
    public partial class Vraag : Window
    {
        public Vraag()
        {
            InitializeComponent();
        }

        private void about_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            this.Close();
        }

        private void home_Click(object sender, RoutedEventArgs e)
        {
            Vraag v = new Vraag();
            v.Show();
            this.Close();
        }

        private void guide_Click(object sender, RoutedEventArgs e)
        {
            guide g = new guide();
            g.Show();
            this.Close();
        }
    }
}
