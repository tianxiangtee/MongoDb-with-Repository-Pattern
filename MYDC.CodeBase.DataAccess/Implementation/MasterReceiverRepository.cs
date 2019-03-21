using Microsoft.Extensions.Options;
using MongoDB.Driver;
using MYDC.CodeBase.DataAccess.EntityModel;
using MYDC.CodeBase.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MYDC.CodeBase.DataAccess.Implementation
{
    public class MasterReceiverRepository : Repository<master_receiver>, IMasterReceiverRepository
    {        

        public MasterReceiverRepository(IOptions<Settings> settings) : base(settings,"master_receiver")
        {
           
        }        
    }
}