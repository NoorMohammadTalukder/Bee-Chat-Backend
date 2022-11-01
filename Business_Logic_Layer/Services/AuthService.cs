using AutoMapper;
using Business_Logic_Layer.BOs;
using Data_Access_Layer;
using Data_Access_Layer.Entity_Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic_Layer.Services
{
    public class AuthService
    {
        //public static UserModel Login(UserModel obj)
        //{
          //  var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<UserModel, User>())).Map<User>(obj);
           // try
            //{
            //    var x = DataAccess.GetAuthDataAccess().Login(data);
            //    return x;
           // }
           // catch
           // {
           //     return "";
           // }
       // }

        public static UserModel Login(string mail)
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<User, UserModel>())).Map<UserModel>(DataAccess.GetAuthDataAccess().Login(mail));
            return data;
        }

         public static UserModel GetUser(string mail)
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<User, UserModel>())).Map<UserModel>(DataAccess.GetAuthDataAccess().Login(mail));
            return data;
        }


    }
}
