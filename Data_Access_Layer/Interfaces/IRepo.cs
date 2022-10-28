using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.Interfaces
{
    public interface IRepo<ClassName, IdType>
    {
        List<ClassName> Get();
        ClassName GetId(IdType id);
        bool Create(ClassName obj);
        bool Update(ClassName obj);
        bool Delete(IdType id);

    }
}
