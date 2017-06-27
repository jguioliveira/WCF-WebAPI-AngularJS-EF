using System;
using System.Runtime.Caching;

namespace JG.Services.WCFAuthentication
{

    public class TokenAuthentication : ITokenAuthentication
    {
        private ObjectCache _cache;

        public TokenAuthentication()
        {
            _cache = MemoryCache.Default;
        }

        private void AddCache(AuthenticationResult token)
        {   
            CacheItem cacheItem = new CacheItem(token.Token.ToString(), token);
            CacheItemPolicy policy = new CacheItemPolicy();
            policy.AbsoluteExpiration = token.Expiration;
            _cache.Add(cacheItem, policy);
        }

        public AuthenticationResult GetToken()
        {
            AuthenticationResult tokenResult = new AuthenticationResult();
            tokenResult.Token = Guid.NewGuid();
            tokenResult.Expiration = DateTime.Now.AddMinutes(1);

            this.AddCache(tokenResult);
            
            return tokenResult;
        }

        public bool TokenValidate(string token)
        {
            if (string.IsNullOrEmpty(token))
               return false;

            return _cache.Contains(token); ;
        }
    }
}
