using Member.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Member.Data.Interface
{
    public interface IMember
    {
        List<Members> GetAllMember();
        Members GetMember(int id);
        
    }
}
