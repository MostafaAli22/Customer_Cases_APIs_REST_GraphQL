// Models/Customer.cs
using System;
using System.Collections.Generic;

namespace APISolution.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime CreatedDate { get; set; }

        public Case? Cases { get; set; }
    }
}
