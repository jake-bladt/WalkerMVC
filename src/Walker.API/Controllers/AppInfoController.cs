using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Walker.API.Controllers
{
    public class AppInfoController : ApiController
    {
        public HttpResponseMessage Get()
        {
            return Request.CreateResponse(HttpStatusCode.OK, new { ApplicationName = "Walker" });
        }
    }
}
