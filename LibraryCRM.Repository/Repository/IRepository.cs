using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCRM.Repository.Repository
{
    public interface IRepository<T> : IDisposable
    {
        void Create(T entity);
        void Delete(T entity);
        void Update(T entity);
        IQueryable<T> GetAll();
        IQueryable<T> GetEntity(int id);
        void SaveChanges();
    }
}
