﻿using Business_Logic_Layer.BOs;
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

        [Route("api/login/user")]
        [HttpPost]
        public HttpResponseMessage Login(UserModel obj )
        {
            //return Request.CreateResponse(HttpStatusCode.OK,"nfjdnbf");
            var data = AuthService.Login(obj.Email);
            if (data !=null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            return Request.CreateResponse(HttpStatusCode.NotFound,"Not Found");
        }

        // [Route("api/login/user/get/{email})]
         [Route("api/login/user/{email}/")]
        [HttpGet]
        public HttpResponseMessage GetUser(string email )
        {
            //return Request.CreateResponse(HttpStatusCode.OK,"nfjdnbf");
            var data = AuthService.Login(email);
            if (data !=null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            return Request.CreateResponse(HttpStatusCode.NotFound,"Not Found");
        }






        [Route("api/create/messsage/user")]
        [HttpPost]
        public HttpResponseMessage CreateMessage(ConversationModel obj)
        {
            bool data = UserService.CreateMessage(obj);
            return Request.CreateResponse(data ? true : false);

        }

        [Route("api/all/coversation/{id1}/{id2}")]
        [HttpGet]
        public HttpResponseMessage Messages(int id1,int id2)
        {

            var data = UserService.Messages(id1, id2);
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }

        [Route("api/delete/chat/{id}")]
        [HttpGet]
        public HttpResponseMessage DeleteInstitution(int id)
        {
            bool data = UserService.DeleteChat(id);
            return Request.CreateResponse(data ? true : false);

        }
    }
}
