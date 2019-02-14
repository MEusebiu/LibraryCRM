using LibraryCRM.DataContext.DbContext;
using LibraryCRM.DataContext.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCRM.Repository.Repository
{
    public class BookRepository : Repository<Book>, IBookRepository
    {
        public BookRepository(LibraryDbContext dbContext) : base(dbContext)
        {

        }

        public IList<Book> GetAllDetails()
        {
            return _dbContext.Books.Include("Author").Include("Genre").Include("Reviews").ToList();
        }

        public Dictionary<int, string> GetBookAuthors()
        {
            return _dbContext.Authors.ToDictionary(x => x.Id, x => x.FirstName);
        }

        public Dictionary<int, string> GetBookGenres()
        {
            return _dbContext.Genres.ToDictionary(x => x.Id, x => x.Name);
        }

        public IList<Review> GetBookReviews()
        {
            return _dbContext.Reviews.ToList();
        }
    }
}
