using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GoSecuri
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            //var btn = new Button();
            
        }

      
        private void btnCBERTHIER_Clicked(object sender, EventArgs e)
        {
            Application.Current.Properties["test"] = btnCBERTHIER.Text;
            Navigation.PushAsync(new InfosEmploye());
        }
         
        private void btnSCONNOR_Clicked(object sender, EventArgs e)
        {
            Application.Current.Properties["test"] = btnSCONNOR.Text;
            Navigation.PushAsync(new InfosEmploye());
        }

        private void btnMJEANAI_Clicked(object sender, EventArgs e)
        {
            Application.Current.Properties["test"] =  btnMJEANAI.Text;
            Navigation.PushAsync(new InfosEmploye());
        }

        private void btnAFOLEY_Clicked(object sender, EventArgs e)
        {
            Application.Current.Properties["test"] = btnAFOLEY.Text;
            Navigation.PushAsync(new InfosEmploye());
        }

        private void btnMRIGGS_Clicked(object sender, EventArgs e)
        {
            Application.Current.Properties["test"] = btnMRIGGS.Text;
            Navigation.PushAsync(new InfosEmploye());
        }

        private void btnJWEST_Clicked(object sender, EventArgs e)
        {
            Application.Current.Properties["test"] = btnJWEST.Text;
            Navigation.PushAsync(new InfosEmploye());
        }

        private void btnSHOLMES_Clicked(object sender, EventArgs e)
        {
            Application.Current.Properties["test"] = btnSHOLMES.Text;
            Navigation.PushAsync(new InfosEmploye());
        }

        private void btnJROULETABILLE_Clicked(object sender, EventArgs e)
        {
            Application.Current.Properties["test"] = btnJROULETABILLE.Text;
            Navigation.PushAsync(new InfosEmploye());
        }
    }
}