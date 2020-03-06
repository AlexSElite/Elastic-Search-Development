using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Elastic_Search_Development.Models
{
    public class HumanResource
    {
        public string NationalIdNumber { get; set; }
        public string LoginID { get; set; }
        public string OrganizationNode { get; set; }
        public int? OrganizationLevel { get; set; }
        public string Jobtitle { get; set; }
        public string BirthDate { get; set; }
        public string MaritalStatus { get; set; }
        public string Gender { get; set; }
        public DateTime? HireDate { get; set; }
        public bool? SalariedFlag { get; set; }
        public int? VacationHours { get; set; }
        public int? SickLeaveHours { get; set; }
        public bool? CurrentFlag { get; set; }
        public string rowguid { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}