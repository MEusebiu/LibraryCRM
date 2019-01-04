using System.Collections.Generic;

namespace LibraryCRM.DataContext.Entities
{
    public class Genre : Entity //Lookup 
    {
        public string Name { get; set; }

        public ICollection<Author> Authors { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}
