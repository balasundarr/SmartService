using Smart.Wasl.Homes.Clients.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Smart.Wasl.Homes.Clients.Core.Services.Authentication
{
    public class FakeAuthenticationService : IAuthenticationService
    {
        private static bool AuthSucceded;

        public bool IsAuthenticated
        {
            get
            {
                return AuthSucceded;
            }
        }

        public User AuthenticatedUser => new User
        {
            Email = "balasundr@gabss.net",
            Name = "Balasundar",
            LastName = "Ramamoorthi"
        };

        public async Task<bool> LoginAsync(string userName, string password)
        {
            await Task.Delay(500);

            bool succeeded = true;

            if (userName.StartsWith("1"))
            {
                succeeded = false;
            }

            AuthSucceded = succeeded;

            return succeeded;
        }

        public Task<bool> LoginWithMicrosoftAsync()
        {
            return Task.FromResult(false);
        }

        public Task<bool> UserIsAuthenticatedAndValidAsync()
        {
            return Task.FromResult(IsAuthenticated);
        }

        public Task LogoutAsync()
        {
            AuthSucceded = false;

            return Task.FromResult(false);
        }
    }
}
