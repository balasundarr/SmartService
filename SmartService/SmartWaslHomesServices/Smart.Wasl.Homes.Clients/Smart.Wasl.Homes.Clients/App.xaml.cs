using Microsoft.Identity.Client;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using System;


[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Smart.Wasl.Homes.Clients
{
    public partial class App : Application
    {
        public static PublicClientApplication AuthenticationClient { get; set; }

        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
