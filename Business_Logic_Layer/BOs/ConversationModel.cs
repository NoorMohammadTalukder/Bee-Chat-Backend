using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic_Layer.BOs
{
    public class ConversationModel
    {
        public int Id { get; set; }
        public Nullable<int> ChatId { get; set; }
        public string Text { get; set; }
        public string Time { get; set; }
        public Nullable<int> UserId { get; set; }
        public Nullable<int> UserId2 { get; set; }
    }
}
