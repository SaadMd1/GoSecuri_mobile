using GoSecuri.Services;
using GoSecuri.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GoSecuri
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new NavigationPage(new MainPage())
            {
                BarBackgroundColor = Color.FromHex("#379EC1"),
                BarTextColor = Color.White,
               // Title=     
            };
            
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
