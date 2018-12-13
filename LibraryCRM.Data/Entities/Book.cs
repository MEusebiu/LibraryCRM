using System;
using System.Collections.Generic;

namespace LibraryCRM.Data.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public  string Title { get; set; }
        public string Description { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int GenreId { get; set; }
        public int AuthorId { get; set; }
        public Genre Genre { get; set; }
        public Author Author { get; set; }
        public List<Review> Reviews { get; set; }
    }
}
