using Data_Access_Layer.Entity_Framework;
using Data_Access_Layer.Interfaces;
using Data_Access_Layer.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer
{
    public class DataAccess
    {
        static ChatAppEntities db = new ChatAppEntities();

        public static IRepo<User, int> GetUserDataAccess()
        {

            return new UserRepo(db);
        }
    }



}
