using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Elastic_Search_Development.Models
{
    public class Address
    {
        public int AddressId { get; set; }
        public int CustomerId { get; set; }

        // Fields
        [MaxLength(65)]
        public string Name { get; set; }
        [MaxLength(61)]
        public string Attention { get; set; }
        [MaxLength(61)]
        public string Address1 { get; set; }
        [MaxLength(61)]
        public string Address2 { get; set; }
        [MaxLength(61)]
        public string Address3 { get; set; }
        [MaxLength(35)]
        public string City { get; set; }
        [MaxLength(29)]
        public string StateProvince { get; set; }
        [MaxLength(11)]
        public string PostalCode { get; set; }
        [MaxLength(61)]
        public string County { get; set; }
        [MaxLength(61)]
        public string Country { get; set; }
        [MaxLength(21)]
        public string Phone1 { get; set; }
        [MaxLength(21)]
        public string Phone2 { get; set; }
        [MaxLength(21)]
        public string Phone3 { get; set; }
        [MaxLength(21)]
        public string Fax { get; set; }
    }
}