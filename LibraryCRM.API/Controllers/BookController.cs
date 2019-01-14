using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using LibraryCRM.API.Models;

namespace LibraryCRM.API.Controllers
{
    public class BookController : ApiController
    {
        [HttpGet]
        public IHttpActionResult GetAllBooks()
        {
            var books = PopulateWithBooksMock();
            return Ok(books);
        }

        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            var books = PopulateWithBooksMock();
            var searchedBook = books.Where(x => x.Id == id);

            return searchedBook == null ? NotFound() : (IHttpActionResult)Ok(searchedBook);
        }

        private IList<Book> PopulateWithBooksMock()
        {
            var bookListMock = new List<Book>
            {
                new Book { Id = 1, Author = "Eusebiu1", Title = "C# LEARNING1", Year = 2018 },
                new Book { Id = 2, Author = "Eusebiu2", Title = "C# LEARNING2", Year = 2018 },
                new Book { Id = 3, Author = "Eusebiu3", Title = "C# LEARNING3", Year = 2018 },
                new Book { Id = 4, Author = "Eusebiu4", Title = "C# LEARNING4", Year = 2018 }
            };

            return bookListMock;
        }
    }
}
