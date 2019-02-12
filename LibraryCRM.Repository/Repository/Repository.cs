using LibraryCRM.DataContext.DbContext;
using LibraryCRM.DataContext.Entities;
using System;
using System.Data.Entity;
using System.Linq;


namespace LibraryCRM.Repository.Repository
{
    public class Repository<T> : IRepository<T> where T : Entity
    {
        private DbSet<T> _dbSet;
        protected LibraryDbContext _dbContext;

        public Repository(LibraryDbContext dbContext)
        {
            _dbSet = dbContext.Set<T>();
            _dbContext = dbContext;
        }

        public void Create(T entity)
        {
            _dbSet.Add(entity);
            SaveChanges();
        }

        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
            SaveChanges();
        }

        public IQueryable<T> GetAll()
        {
            return _dbSet;
        }

        public IQueryable<T> GetEntity(int id)
        {
            return _dbSet.Where(x => x.Id == id);
        }

        public void Update(T entity)
        {
            _dbSet.Attach(entity);
            _dbContext.Entry(entity).State = EntityState.Modified;
            SaveChanges();
        }

        public void SaveChanges()
        {
            _dbContext.SaveChanges();
        }

        public void Dispose()
        {
        }

    }

}
