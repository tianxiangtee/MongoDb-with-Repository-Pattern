using Microsoft.Extensions.Options;
using MongoDB.Driver;
using MYDC.CodeBase.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MYDC.CodeBase.DataAccess.Implementation
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly MongoContext _context;

        public Repository(IOptions<Settings> settings)
        {
            _context = new MongoContext(settings);
        }
        public int Count(Func<T, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public void Create(T entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> Find(Func<T, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<T>>GetfromRepo(string collection)
        {
            var test = _context.mongoDatabase.GetCollection<T>(collection);
            var temp = await _context.mongoDatabase.GetCollection<T>(collection).Find(x => true).ToListAsync();
            return temp;           
        }

        public async Task<T> GetfromRepoById(string collection,string id)
        {
            var keyword = Builders<T>.Filter.Eq("_Id", id);
            var temp = await _context.mongoDatabase.GetCollection<T>(collection).Find(keyword).FirstOrDefaultAsync();
            return temp;
        }

    }
}
