using Rg.Plugins.Popup.Pages;

namespace Smart.Wasl.Homes.Clients.Core.Views
{
    public partial class OpenDoorView : PopupPage
    {
		public OpenDoorView ()
		{
			InitializeComponent ();
        }

        protected override bool OnBackgroundClicked()
        {
            return false;
        }
    }
}