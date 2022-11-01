using Data_Access_Layer.Entity_Framework;
using Data_Access_Layer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.Repos
{

     public class AuthRepo : IAuth<User>
    {
        ChatAppEntities db;

        public AuthRepo(ChatAppEntities db)
        {
            this.db = db;
        }

        public User Login(string mail)
        {
            var x = db.Users.FirstOrDefault(e => e.Email == mail);
           
                return x;
         
        }
         public User GetUser(string mail)
        {
            var x = db.Users.FirstOrDefault(e => e.Email == mail);
           
                return x;
         
        }

        
    }
}
