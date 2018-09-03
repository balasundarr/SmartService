using Smart.Wasl.Homes.Clients.Core.Helpers;
using Xamarin.Forms;

namespace Smart.Wasl.Homes.Clients.Core.Views
{
    public partial class LoginView : ContentPage
    {
        public LoginView()
        {
            NavigationPage.SetHasNavigationBar(this, false);

            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            StatusBarHelper.Instance.MakeTranslucentStatusBar(true);
        }
    }
}