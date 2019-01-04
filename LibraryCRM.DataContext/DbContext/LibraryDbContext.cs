using System.Data.Entity;
using LibraryCRM.DataContext.Entities;

namespace LibraryCRM.DataContext.DbContext
{
    public class LibraryDbContext : System.Data.Entity.DbContext
    {
        public LibraryDbContext() : base("UniLibraryDB")
        { }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserBook> UserBooks { get; set; }
    }
}
