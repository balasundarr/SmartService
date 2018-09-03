using Microsoft.Identity.Client;
using Newtonsoft.Json.Linq;
using Xamarin.Forms;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;


namespace Smart.Wasl.Homes.Clients.Core.Services.Authentication
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IBrowserCookiesService _browserCookiesService;
        private readonly IAvatarUrlProvider _avatarProvider;

        public AuthenticationService(
            IBrowserCookiesService browserCookiesService,
            IAvatarUrlProvider avatarProvider)
        {
            _browserCookiesService = browserCookiesService;
            _avatarProvider = avatarProvider;
        }

        public bool IsAuthenticated => AppSettings.User != null;

        public Models.User AuthenticatedUser => AppSettings.User;

        public Task<bool> LoginAsync(string email, string password)
        {
            var user = new Models.User
            {
                Email = email,
                Name = email,
                LastName = string.Empty,
                AvatarUrl = _avatarProvider.GetAvatarUrl(email),
                Token = email,
                LoggedInWithMicrosoftAccount = false
            };

            AppSettings.User = user;

            return Task.FromResult(true);
        }

        public async Task<bool> LoginWithMicrosoftAsync()
        {
            bool succeeded = false;

            try
            {

                String[] scope = new string[] { AppSettings.B2cPolicy };


                IEnumerable<IAccount> accounts = await App.AuthenticationClient.GetAccountsAsync();
                IAccount firstAccount = accounts.FirstOrDefault(a => a.HomeAccountId.Identifier == AuthenticatedUser.Id);
                var result =
                    await App.AuthenticationClient.AcquireTokenSilentAsync(
                         scope, firstAccount);
                
                Models.User user = AuthenticationResultHelper.GetUserFromResult(result);
                user.AvatarUrl = _avatarProvider.GetAvatarUrl(user.Email);
                user.LoggedInWithMicrosoftAccount = true;
                AppSettings.User = user;

                succeeded = true;
            }
            catch (MsalException ex)
            {
                if (ex.ErrorCode !=  Microsoft.Identity.Client.MsalClientException.AuthenticationCanceledError)
                {
                    System.Diagnostics.Debug.WriteLine($"Error with MSAL authentication: {ex}");
                    throw new ServiceAuthenticationException();
                }
            }

            return succeeded;
        }

        public async Task<bool> UserIsAuthenticatedAndValidAsync()
        {
            if (!IsAuthenticated)
            {
                return false;
            }
            else if (!AuthenticatedUser.LoggedInWithMicrosoftAccount)
            {
                return true;
            }
            else
            {
                bool refreshSucceded = false;

                try
                {
                    String[] scope = new string[] { AppSettings.B2cPolicy };

               
                    IEnumerable<IAccount> accounts = await App.AuthenticationClient.GetAccountsAsync();
                    IAccount firstAccount = accounts.FirstOrDefault( a=> a.HomeAccountId.Identifier == AuthenticatedUser.Id);
                    AuthenticationResult ar =
                        await App.AuthenticationClient.AcquireTokenSilentAsync(
                             scope, firstAccount);

                    SaveAuthenticationResult(ar);

                    refreshSucceded = true;
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine($"Error with MSAL refresh attempt: {ex}");
                }

                return refreshSucceded;
            }
        }

        public async Task LogoutAsync()
        {
            AppSettings.RemoveUserData();
            await _browserCookiesService.ClearCookiesAsync();
        }

        private void SaveAuthenticationResult(AuthenticationResult result)
        {
            Models.User user = AuthenticationResultHelper.GetUserFromResult(result);
            user.AvatarUrl = _avatarProvider.GetAvatarUrl(user.Email);
            AppSettings.User = user;
        }
       
    }
}
