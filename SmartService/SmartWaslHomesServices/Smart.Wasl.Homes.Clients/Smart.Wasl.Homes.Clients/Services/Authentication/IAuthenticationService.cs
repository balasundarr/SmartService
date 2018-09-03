using Smart.Wasl.Homes.Clients.Core.Models;
using System.Threading.Tasks;

namespace Smart.Wasl.Homes.Clients.Core.Services.Authentication
{
    public interface IAuthenticationService
    {

        bool IsAuthenticated { get; }

        User AuthenticatedUser { get; }

        Task<bool> LoginAsync(string email, string password);

        Task<bool> LoginWithMicrosoftAsync();

        Task<bool> UserIsAuthenticatedAndValidAsync();

        Task LogoutAsync();
    }
}
