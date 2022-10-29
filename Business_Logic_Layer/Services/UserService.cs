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

        public static bool Login(UserModel obj)
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<UserModel, User>())).Map<User>(obj);
            try
            {
                var x=DataAccess.GetUserDataAccess().Login(data);
                return x;
            }
            catch
            {
                return false;
            }
        }

        public static bool x()
        {
            return true;
        }

        public static List<ConversationModel> Messages(int id1,int id2)
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<Conversation, ConversationModel>())).Map<List<ConversationModel>>(DataAccess.GetConversationDataAccess().Get());
            
            var messges = (from i in data
                                where (i.UserId == id1  || i.UserId2==id1) && (i.UserId == id2 || i.UserId2 == id2)

                                select i).ToList();
            return messges;
        }


        public static bool CreateMessage(ConversationModel obj)
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<ConversationModel, Conversation>())).Map<Conversation>(obj);

            try
            {
                DataAccess.GetConversationDataAccess().Create(data);

                return true;

            }
            catch
            {
                return false;
            }

        }

    }
}
