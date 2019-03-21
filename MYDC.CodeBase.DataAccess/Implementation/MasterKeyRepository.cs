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
    public class MasterKeyRepository : Repository<master_keyword>, IMasterKeyRepository
    {
        private readonly MongoContext mongoContext = null;

        public MasterKeyRepository(IOptions<Settings> settings) : base(settings)
        {
            mongoContext = new MongoContext(settings);
        }
        public async Task<IEnumerable<master_keyword>> Get()
        {
            var temp = await mongoContext.master_keyword.Find(x => true).ToListAsync();
            return temp;
        }

        public async Task<master_keyword> GetById(string id)
        {
            var keyword = Builders<master_keyword>.Filter.Eq("_Id", id);
            return await mongoContext.master_keyword.Find(keyword).FirstOrDefaultAsync();
        }
    }
}
