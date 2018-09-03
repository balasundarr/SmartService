using Rg.Plugins.Popup.Pages;

namespace Smart.Wasl.Homes.Clients.Core.Views
{
    public partial class CheckoutView : PopupPage
    {
		public CheckoutView ()
		{
			InitializeComponent ();
        }

        protected override bool OnBackgroundClicked()
        {
            return false;
        }
    }
}