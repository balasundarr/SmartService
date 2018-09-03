using System;
using System.Collections.Generic;
using System.Text;

namespace Smart.Wasl.Homes.Clients.Core.Services.Authentication
{
    public interface IAvatarUrlProvider
    {
        string GetAvatarUrl(string email);
    }
}
