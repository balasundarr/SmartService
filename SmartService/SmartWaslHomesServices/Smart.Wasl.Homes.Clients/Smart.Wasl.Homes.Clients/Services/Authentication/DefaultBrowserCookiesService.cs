﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Smart.Wasl.Homes.Clients.Core.Services.Authentication
{
    public class DefaultBrowserCookiesService : IBrowserCookiesService
    {
        public Task ClearCookiesAsync()
        {
            return Task.FromResult(true);
        }
    }
}
