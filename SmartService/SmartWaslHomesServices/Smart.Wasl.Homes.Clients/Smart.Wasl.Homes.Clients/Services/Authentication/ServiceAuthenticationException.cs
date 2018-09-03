using System;
using System.Collections.Generic;
using System.Text;

namespace Smart.Wasl.Homes.Clients.Core.Services.Authentication
{
    public class ServiceAuthenticationException : Exception
    {
        public string Content { get; }

        public ServiceAuthenticationException()
        {
        }

        public ServiceAuthenticationException(string content)
        {
            Content = content;
        }
    }
}
