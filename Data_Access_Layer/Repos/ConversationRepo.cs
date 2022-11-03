using Data_Access_Layer.Entity_Framework;
using Data_Access_Layer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.Repos
{
    public class ConversationRepo : IRepo<Conversation, int>
    {
        ChatAppEntities db;

        public ConversationRepo(ChatAppEntities db)
        {
            this.db = db;
        }

        public bool Create(Conversation obj)
        {
            try
            {
                db.Conversations.Add(obj);
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
            var x = db.Conversations.FirstOrDefault(e => e.Id == id);
            db.Conversations.Remove(x);
            db.SaveChanges();
            return true;
        }

        public List<Conversation> Get()
        {
            return db.Conversations.ToList();
        }

        public Conversation GetId(int id)
        {
            throw new NotImplementedException();
        }

        public bool Login(Conversation obj)
        {
            throw new NotImplementedException();
        }

        public bool Update(Conversation obj)
        {
            throw new NotImplementedException();
        }

        public List<Conversation> Messages()
        {
            throw new NotImplementedException();
        }
    }
}
