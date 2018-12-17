using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryCRM.Data.Entities
{
    public class Author : Entity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public List<Book> Books { get; set; }
        public List<Genre> Genres { get; set; }
    }
}
