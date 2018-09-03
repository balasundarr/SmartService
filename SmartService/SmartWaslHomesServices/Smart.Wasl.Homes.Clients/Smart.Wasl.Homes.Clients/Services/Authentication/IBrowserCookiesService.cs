using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Smart.Wasl.Homes.Clients.Core.Services.Authentication
{
    public interface IBrowserCookiesService
    {
        Task ClearCookiesAsync();
    }
}
