using SDWardWebApi.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace SDWardWebApi.Filters
{
    public class CustomFilter: AuthorizationFilterAttribute
    {
        public  override void OnAuthorization(HttpActionContext actionContext)
        {
            try
            {
                var obj = actionContext.Request.Headers.GetValues("Api_Authentication").FirstOrDefault();
                if (!obj.Equals(TokenGenerator.Token))
                {
                    actionContext.Response = actionContext.Request.CreateResponse(System.Net.HttpStatusCode.BadRequest,
                        new { Status = "Authentication Error", TimeStamp = DateTime.Now });
                }
            }
            catch (Exception)
            {

                actionContext.Response = actionContext.Request.CreateResponse(System.Net.HttpStatusCode.BadRequest,
                    new { Status = "Authentication Error", TimeStamp = DateTime.Now });
            }

        }
    }
}