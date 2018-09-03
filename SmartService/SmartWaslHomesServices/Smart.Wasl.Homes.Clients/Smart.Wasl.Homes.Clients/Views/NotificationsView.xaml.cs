using Smart.Wasl.Homes.Clients.Core.Helpers;
using Xamarin.Forms;

namespace Smart.Wasl.Homes.Clients.Core.Views
{
    public partial class NotificationsView : ContentPage
    {
        public NotificationsView()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            StatusBarHelper.Instance.MakeTranslucentStatusBar(false);
        }
    }
}