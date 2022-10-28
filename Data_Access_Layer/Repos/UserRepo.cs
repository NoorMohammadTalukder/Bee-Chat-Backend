using Data_Access_Layer.Entity_Framework;
using Data_Access_Layer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.Repos
{
    public class UserRepo:IRepo<User,int>
    {
        ChatAppEntities db;

        public UserRepo(ChatAppEntities db)
        {
            this.db = db;
        }

        public bool Create(User obj)
        {
            try
            {
                db.Users.Add(obj);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<User> Get()
        {
            
             return db.Users.ToList();
            

        }

        public User GetId(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(User obj)
        {
            throw new NotImplementedException();
        }
    }
}
