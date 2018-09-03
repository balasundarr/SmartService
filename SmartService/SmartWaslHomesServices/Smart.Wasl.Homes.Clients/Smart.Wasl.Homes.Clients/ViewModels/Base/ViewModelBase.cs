using System.Threading.Tasks;
using Smart.Wasl.Homes.Clients.Core.Services.Dialog;
using Smart.Wasl.Homes.Clients.Core.Services.Navigation;
using Xamarin.Forms;

namespace Smart.Wasl.Homes.Clients.Core.ViewModels.Base
{
    public abstract class ViewModelBase : BindableObject
    {
        private bool _isBusy;

        protected readonly IDialogService DialogService;
        protected readonly INavigationService NavigationService;

        public ViewModelBase()
        {
            DialogService = Locator.Instance.Resolve<IDialogService>();
            NavigationService = Locator.Instance.Resolve<INavigationService>();
        }

        public bool IsBusy
        {
            get
            {
                return _isBusy;
            }

            set
            {
                _isBusy = value;
                OnPropertyChanged();
            }
        }

        public virtual Task InitializeAsync(object navigationData)
        {
            return Task.FromResult(false);
        }
    }
}