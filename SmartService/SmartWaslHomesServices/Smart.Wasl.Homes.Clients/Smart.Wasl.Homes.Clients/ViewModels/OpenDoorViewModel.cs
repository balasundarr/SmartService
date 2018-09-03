using Rg.Plugins.Popup.Services;
using Smart.Wasl.Homes.Clients.Core.Services.NFC;
using Smart.Wasl.Homes.Clients.Core.ViewModels.Base;
using System.Windows.Input;
using Xamarin.Forms;
using System.Threading.Tasks;
using Smart.Wasl.Homes.Clients.Core.Services.Authentication;
using Smart.Wasl.Homes.Clients.Core.Services.Analytic;
using Smart.Wasl.Homes.Clients.Core.Models;
using Newtonsoft.Json;

namespace Smart.Wasl.Homes.Clients.Core.ViewModels
{
    public class OpenDoorViewModel : ViewModelBase
    {
        private readonly IAuthenticationService _authenticationService;
        private readonly INfcService _nfcService;
        private readonly IAnalyticService _analyticService;

        public OpenDoorViewModel(
            IAuthenticationService authenticationService,
            IAnalyticService analyticService)
        {
            _authenticationService = authenticationService;
            _analyticService = analyticService;
            _nfcService = DependencyService.Get<INfcService>();
        }

        public ICommand ClosePopupCommand => new AsyncCommand(ClosePopupAsync);

        public override async Task InitializeAsync(object navigationData)
        {
            if (_nfcService != null)
            {
                if (!_nfcService.IsAvailable)
                {
                    await DialogService.ShowAlertAsync(Resources.NoNfc, Resources.Information, Resources.DialogOk);
                    return;
                }

                var authenticatedUser = _authenticationService.AuthenticatedUser;

                var nfcParameter = new NfcParameter
                {
                    Username = authenticatedUser.Name,
                    Avatar = authenticatedUser.AvatarUrl
                };

                var serializedMessage = JsonConvert.SerializeObject(nfcParameter);

                MessagingCenter.Send(serializedMessage, MessengerKeys.SendNFCToken);
                _analyticService.TrackEvent("OpenDoor");
            }
        }

        private Task ClosePopupAsync()
        {
            return PopupNavigation.PopAllAsync(true);
        }
    }
}