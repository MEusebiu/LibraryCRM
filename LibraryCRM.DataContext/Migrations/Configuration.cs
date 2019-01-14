namespace LibraryCRM.DataContext.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<LibraryCRM.DataContext.DbContext.LibraryDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(LibraryCRM.DataContext.DbContext.LibraryDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.Books.AddOrUpdate(
                new Entities.Book { Id = 1, AuthorId = 1, GenreId = 1, Description = "These new beginnings", Title = "Ghosts are following", Year = 2018 }, 
                new Entities.Book { Id = 2, AuthorId = 1, GenreId = 1, Description = "In the heart of the sea", Title = "Moby dick", Year = 2018 },
                new Entities.Book { Id = 3, AuthorId = 1, GenreId = 1, Description = "Someone is watching for you out there", Title = "Creepy little fellas", Year = 2018 },
                new Entities.Book { Id = 4, AuthorId = 1, GenreId = 1, Description = "When you feel the breeze", Title = "Alone on the ocean", Year = 2008 },
                new Entities.Book { Id = 5, AuthorId = 1, GenreId = 1, Description = "Screens are watching", Title = "C++ For Noobs", Year = 2000 },
                new Entities.Book { Id = 6, AuthorId = 1, GenreId = 1, Description = "Coming for the rescue", Title = "Avengers", Year = 2018 },
                new Entities.Book { Id = 7, AuthorId = 1, GenreId = 1, Description = "Love is all that matters", Title = "The notebook", Year = 2005 },
                new Entities.Book { Id = 8, AuthorId = 1, GenreId = 1, Description = "This can change your life", Title = "One year abroad", Year = 2018 },
                new Entities.Book { Id = 9, AuthorId = 1, GenreId = 1, Description = "Destiny is all", Title = "The last kingdom", Year = 2018 },
                new Entities.Book { Id = 10, AuthorId = 1, GenreId = 1, Description = "Blind guy fights for justice", Title = "Daredevil", Year = 2018 }
                );

            context.Authors.AddOrUpdate(
                new Entities.Author { Id = 1, FirstName = "John", LastName = "Snow" },
                new Entities.Author { Id = 2, FirstName = "Mircea", LastName = "Zapada" },
                new Entities.Author { Id = 3, FirstName = "Tudose", LastName = "Grizz" },
                new Entities.Author { Id = 4, FirstName = "Vali", LastName = "Barbu" },
                new Entities.Author { Id = 5, FirstName = "Panciu", LastName = "Vlad" },
                new Entities.Author { Id = 6, FirstName = "Alina", LastName = "Zoe" }
                );

            context.Genres.AddOrUpdate(
                new Entities.Genre { Id = 1, Name = "Drama" },
                new Entities.Genre { Id = 2, Name = "Comics" },
                new Entities.Genre { Id = 3, Name = "Horror" },
                new Entities.Genre { Id = 4, Name = "Amusing" },
                new Entities.Genre { Id = 5, Name = "Novel" },
                new Entities.Genre { Id = 6, Name = "Sci-Fi" }
                );
        }
    }
}
