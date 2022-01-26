using System;
using System.Collections.Generic;
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


namespace Projectweek
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();


            //Dit moet gebeuren als de qr code gescand wordt
            lblVraag.Content = "Yeet?";
            lblAntA.Content = "a | Niks";
            lblAntB.Content = "b | Laat vallen";
            lblAntC.Content = "c | Gooi";
        }

        private void Btn_Submit_Click(object sender, RoutedEventArgs e)
        {

            if (lblVraag.Content == "Yeet?" && Antwoord.Text == "c" || Antwoord.Text == "C")
            {
                lblVraag.Content = "Romeinen ...";
                lblAntA.Content = "a | bestaan";
                lblAntB.Content = "b | zijn dood";
                lblAntC.Content = "c | china";
            }
            else if (lblVraag.Content == "Romeinen ..." && Antwoord.Text == "b" || Antwoord.Text == "B")
            {
                lblVraag.Content = "romeinse goden zijn";
                lblAntA.Content = "a | grieks";
                lblAntB.Content = "b | noors";
                lblAntC.Content = "c | chinees";
            }
            else if (lblVraag.Content == "romeinse goden zijn" && Antwoord.Text == "a" || Antwoord.Text == "A")
            {
                lblVraag.Content = "Welke taal werd door de romeinen gesproken";
                lblAntA.Content = "a | latijns";
                lblAntB.Content = "b | latijn";
                lblAntC.Content = "c | limburigs";
            }
            else if (lblVraag.Content == "Welke taal werd door de romeinen gesproken" && Antwoord.Text == "c" || Antwoord.Text == "C")
            {
                lblVraag.Content = "what is love";
                lblAntA.Content = "a | baby hurt me";
                lblAntB.Content = "b | rip and tear";
                lblAntC.Content = "c | baby dont hurt me";
            }
            //Als alle vragen op zijn
            else if (lblVraag.Content == "what is love" && Antwoord.Text == "c" || Antwoord.Text == "C") Antwoord.Text = "Goed gedaan, je bent klaar!";
            //Als de vragen fout zijn
            else Antwoord.Text = "Fout";
        }


    }
}
