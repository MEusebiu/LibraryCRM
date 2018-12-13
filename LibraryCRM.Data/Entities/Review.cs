using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryCRM.Data.Entities
{
    public class Review
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int BookId { get; set; }
        public string Comment { get; set; }
        public Book Book { get; set; }
        public User User { get; set; }
    }
}
