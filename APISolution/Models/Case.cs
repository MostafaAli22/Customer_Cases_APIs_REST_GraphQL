// Models/Case.cs
using System;

namespace APISolution.Models
{
    public class Case
    {
        public int CaseID { get; set; }
        public int CustomerID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public DateTime CreatedDate { get; set; }

        public Customer? Customer { get; set; }
    }
}
