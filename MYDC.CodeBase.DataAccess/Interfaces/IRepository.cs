using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MYDC.CodeBase.DataAccess.Interfaces
{
    public interface IRepository<T> where T : class
    {

        IEnumerable<T> Find(Func<T, bool> predicate);
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
        int Count(Func<T, bool> predicate);

        Task<IEnumerable<T>> GetfromRepo(string collection);
        Task<T> GetfromRepoById(string collection, string id);
    }
}