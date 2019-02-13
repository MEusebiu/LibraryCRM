using LibraryCRM.DataContext.DbContext;
using LibraryCRM.DataContext.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCRM.Repository.Repository
{
    public class AuthorRepository : Repository<Author>, IAuthorRepository
    {
        public AuthorRepository(LibraryDbContext dbContext) : base(dbContext)
        {

        }

        public IList<Author> GetWhereNamesHam()
        {
            throw new NotImplementedException();
        }
    }
}
