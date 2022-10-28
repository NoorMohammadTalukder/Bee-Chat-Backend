using Business_Logic_Layer.BOs;
using Business_Logic_Layer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace ChatApp.Controllers
{
    [EnableCors("*", "*", "*")]
    public class UserController : ApiController
    {
        [Route("api/create/user")]
        [HttpPost]
        public HttpResponseMessage Create(UserModel obj)
        {
            bool data = UserService.Create(obj);
            return Request.CreateResponse(data ? true : false);

        }

        [Route("api/all/user")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            var data = UserService.Get();
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }
    }
}
