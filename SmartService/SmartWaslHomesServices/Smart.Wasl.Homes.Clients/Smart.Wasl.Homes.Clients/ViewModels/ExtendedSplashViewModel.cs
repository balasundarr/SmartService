using System.Threading.Tasks;
using Smart.Wasl.Homes.Clients.Core.ViewModels.Base;

namespace Smart.Wasl.Homes.Clients.Core.ViewModels
{
    public class ExtendedSplashViewModel : ViewModelBase
    {
        public override async Task InitializeAsync(object navigationData)
        {
            IsBusy = true;

            await NavigationService.InitializeAsync();

            IsBusy = false;
        }
    }
}
