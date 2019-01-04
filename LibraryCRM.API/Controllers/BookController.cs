using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using LibraryCRM.API.Models;

namespace LibraryCRM.API.Controllers
{
    /// <summary>
    /// Book Controller
    /// </summary>
    public class BookController : ApiController
    {
        
        /// <summary>
        /// Get All Books
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IHttpActionResult GetAll()
        {
            var books = PopulateWithBooksMock();
            return Ok(books);
        }

        /// <summary>
        /// Get Book By Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
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
                new Book {Author = "Eusebiu1", Id = 1, Title = "C# LEARNING1", Year = new DateTime(2018, 01, 04)},
                new Book {Author = "Eusebiu2", Id = 2, Title = "C# LEARNING2", Year = new DateTime(2018, 01, 05)},
                new Book {Author = "Eusebiu3", Id = 3, Title = "C# LEARNING3", Year = new DateTime(2018, 01, 06)},
                new Book {Author = "Eusebiu4", Id = 4, Title = "C# LEARNING4", Year = new DateTime(2018, 01, 07)}
            };
            return bookListMock;
        }
    }
}
