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
    public class UserService
    {
        public static bool Create(UserModel obj)
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<UserModel,User >())).Map<User>(obj);

            try
            {
                DataAccess.GetUserDataAccess().Create(data);

                return true;

            }
            catch
            {
                return false;
            }

        }

        public static List<UserModel> Get()
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<User, UserModel>())).Map<List<UserModel>>(DataAccess.GetUserDataAccess().Get());
            return data;
        }
    }
}
