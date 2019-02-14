using LibraryCRM.DataContext.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCRM.Repository.Repository
{
    public interface IBookRepository : IRepository<Book>
    {
        IList<Book> GetAllDetails();
        Dictionary<int, string> GetBookAuthors();
        Dictionary<int, string> GetBookGenres();
        IList<Review> GetBookReviews();
    }
}
