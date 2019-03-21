using MYDC.CodeBase.DataAccess.EntityModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MYDC.CodeBase.DataAccess.Interfaces
{
    public interface IMasterReceiverRepository : IRepository<master_receiver>
    {
        Task<IEnumerable<master_receiver>> Get();
        Task<master_receiver> GetById(string id);
    }
}
