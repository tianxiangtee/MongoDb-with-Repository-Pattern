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
    public class MasterAnnouncementRepository : Repository<master_announcement>, IMasterAnnouncementRepository
    {
        private readonly MongoContext mongoContext = null;

        public MasterAnnouncementRepository(IOptions<Settings> settings) : base(settings)
        {
            mongoContext = new MongoContext(settings);
        }
        
    }
}
