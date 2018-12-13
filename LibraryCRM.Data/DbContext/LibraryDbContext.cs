using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Entity;
using LibraryCRM.Data.Entities;

namespace LibraryCRM.Data.DbContext
{
    public class LibraryDbContext : System.Data.Entity.DbContext
    {
        public LibraryDbContext() : base()
        {
            
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserBooks> UserBooks { get; set; }
    }
}
