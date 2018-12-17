using System;
using System.Collections.Generic;

namespace LibraryCRM.Data.Entities
{
    public class Book : Entity
    { 
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime ReleaseDate { get; set; }
       
        public int GenreId { get; set; }
        public virtual Genre Genre { get; set; }

        public int AuthorId { get; set; }
        public virtual Author Author { get; set; }

        public List<Review> Reviews { get; set; }
    }
}
