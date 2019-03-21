using MYDC.CodeBase.DataAccess.EntityModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MYDC.CodeBase.DataAccess.Interfaces
{
    public interface IMasterKeyRepository : IRepository<master_keyword>
    {
        Task<IEnumerable<master_keyword>> Get();
        Task<master_keyword> GetById(string id);

    }
}