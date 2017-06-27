using System;

namespace JG.Services.WCFAuthentication
{
    public class AuthenticationResult
    {
        public Guid Token { get; set; }
        public DateTime Expiration { get; set; }
    }
}