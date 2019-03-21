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
        private readonly MongoContext mongoContext = null;

        public MasterReceiverRepository(IOptions<Settings> settings) : base(settings)
        {
            mongoContext = new MongoContext(settings);
        }
        public async Task<IEnumerable<master_receiver>> Get()
        {
            var temp = await mongoContext.master_receiver.Find(x => true).ToListAsync();
            return temp;
        }

        public async Task<master_receiver> GetById(string id)
        {
            var keyword = Builders<master_receiver>.Filter.Eq("_Id", id);
            return await mongoContext.master_receiver.Find(keyword).FirstOrDefaultAsync();
        }
    }
}