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
        public string ssn { get; set; }
        public string Email { get; set; }
        public string Score { get; set; }


        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string City { get; set; }
        public string StateProvince { get; set; }
        public string PostalCode { get; set; }
        //public List<Address> Address { get; set; }
    }
}