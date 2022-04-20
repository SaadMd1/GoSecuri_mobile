using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GoSecuri
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InfosEmploye : ContentPage
    {
       
        public InfosEmploye()
        {
            InitializeComponent();

            if (Application.Current.Properties["test"].ToString().Equals("BERTHIER Corinna"))
            {
                LblName.Text = $"Bonjour {Application.Current.Properties["test"].ToString()}";
                LblStatut.Text = "Gardien d'aquarium abandonné";
                imgEmploye1.Source = "https://icons-for-free.com/iconfiles/png/512/female+headset+mic+support+user+woman+icon-1320196265976308430.png";
                LblOutils.Text = "kit" + "\n" + "lampe"; 
            }
    
            if (Application.Current.Properties["test"].ToString().Equals("CONNOR Sophie"))
            {
                LblName.Text = $"Bonjour {Application.Current.Properties["test"].ToString()}";
                LblStatut.Text = "Surveillance entrepôt";
                imgEmploye1.Source = "https://icons-for-free.com/iconfiles/png/512/lady+user+woman+icon-1320166737958685846.png";
                LblOutils.Text = "lacrymo" + "\n" + "kit" + "\n" + "taser" + "\n" + "menottes";
            }

            if (Application.Current.Properties["test"].ToString().Equals("JEANAI Maclaque"))
            {
                LblName.Text = $"Bonjour {Application.Current.Properties["test"].ToString()}";
                LblStatut.Text = "Vigil";
                imgEmploye1.Source = "https://icons-for-free.com/iconfiles/png/512/hipster+lady+woman+icon-1320166733976246755.png";
                LblOutils.Text = "lampe" + "\n" + "kit" + "talke";
            }

            if (Application.Current.Properties["test"].ToString().Equals("FOLEY Arnaud"))
            {
                LblName.Text = $"Bonjour {Application.Current.Properties["test"].ToString()}";
                LblStatut.Text = "Agent de protection";
                imgEmploye1.Source = "https://icons-for-free.com/iconfiles/png/128/queen+queen+of+naboo+woman+icon-1320166700494156922.png";
                LblOutils.Text = "talkies " + "\n" + "kit" + "\n" + "bassard";
            }

            if (Application.Current.Properties["test"].ToString().Equals("RIGGS Mehboula"))
            {
                LblName.Text = $"Bonjour {Application.Current.Properties["test"].ToString()}";
                LblStatut.Text = "Gardien d'aquarium abandonné";
                imgEmploye1.Source = "https://icons-for-free.com/iconfiles/png/512/headset+male+man+support+user+young+icon-1320196267025138334.png";
                LblOutils.Text = "lampe" + "\n" + "kit" + "talke";
            }

            if (Application.Current.Properties["test"].ToString().Equals("WEST Joris"))
            {
                LblName.Text = $"Bonjour {Application.Current.Properties["test"].ToString()}";
                LblStatut.Text = "Surveillance salle évenement";
                imgEmploye1.Source= "https://icons-for-free.com/iconfiles/png/512/business+face+people+icon-1320086457520622872.png";
                LblOutils.Text = "kit" + "\n" + "lacrymo" + "\n" + "gants" + "\n" + "taser" + "\n" + "brassard";
            }

            if (Application.Current.Properties["test"].ToString().Equals("HOLMES Sacha"))
            {
                LblName.Text = $"Bonjour {Application.Current.Properties["test"].ToString()}";
                LblStatut.Text = "Protection civile";
                imgEmploye1.Source = "https://icons-for-free.com/iconfiles/png/512/female+person+user+woman+young+icon-1320196266256009072.png";
                LblOutils.Text = "kit" + "\n" + "lacrymo" + "\n" + "gants" + "\n" + "menottes" + "\n" + "taser" + "\n" + "cyno" + "\n" + "lampe";
            }

            if (Application.Current.Properties["test"].ToString().Equals("ROULETABILLE Julien"))
            {
                LblName.Text = $"Bonjour {Application.Current.Properties["test"].ToString()}";
                LblStatut.Text = "Gardien parking";
                imgEmploye1.Source = "https://icons-for-free.com/iconfiles/png/512/business+costume+male+man+office+user+icon-1320196264882354682.png";
                LblOutils.Text= "taser" + "\n" + "lacrymo" + "\n" + "talky" + "\n" + "bassard" + "\n" + "gants";
            }
        }
    }
}