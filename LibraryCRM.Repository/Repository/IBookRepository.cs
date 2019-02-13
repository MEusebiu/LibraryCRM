using LibraryCRM.DataContext.Entities;
using System.Collections.Generic;

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
