using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryCRM.Data.Entities
{
    public class User : Entity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public Role Role { get; set; }
        public DateTime JoinDate { get; set; }

        public List<Review> Reviews { get; set; }
        public UserBooks UserBooks { get; set; }
    }
}
