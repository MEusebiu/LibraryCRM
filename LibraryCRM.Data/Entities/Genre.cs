using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryCRM.Data.Entities
{
    public class Genre : Entity //Lookup 
    {
        public string Name { get; set; }

        public List<Author> Authors { get; set; }
        public List<Book> Books { get; set; }
    }
}
