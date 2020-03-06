using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Elastic_Search_Development.Models
{
    public class Customer
    {
        public string CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string DateOfBirth { get; set; }
        public string SSN { get; set; }
        public string Email { get; set; }
        public IEnumerable<Address> Address{get; set;}
    }
}