using JG.Services.WebAPI.AuthenticationService;
using System;
using System.Net;
using System.Net.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace JG.Services.WebAPI.Filters
{
    public class AuthenticationFilter : ActionFilterAttribute
    {
        const string TOKEN_AUTHENTICATION = "token";

        public override void OnActionExecuting(HttpActionContext actionContext)
        {
            try
            {
                if (actionContext == null) throw new ArgumentNullException("actionContext");

                if (!actionContext.Request.Headers.Contains(TOKEN_AUTHENTICATION))
                {
                    actionContext.Response = new HttpResponseMessage(HttpStatusCode.Unauthorized);
                    return;
                }

                string token = ((string[])(actionContext.Request.Headers.GetValues(TOKEN_AUTHENTICATION)))[0].ToString();

                ITokenAuthentication serviceAuthentication = new TokenAuthenticationClient();
                bool result = serviceAuthentication.TokenValidate(token);

                if (!result)
                {
                    actionContext.Response = new HttpResponseMessage(HttpStatusCode.Unauthorized);
                    return;
                }

                base.OnActionExecuting(actionContext);
            }
            catch (Exception ex)
            {
                actionContext.Response = new System.Net.Http.HttpResponseMessage(System.Net.HttpStatusCode.InternalServerError);
                return;
            }
            
        }
    }
}