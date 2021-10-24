using Application.DTOs.Contact;
using System;

namespace Application.DTOs.Employee
{
    public class EmployeeGetDTO
    {
        public int? EmployeeID { get; set; }
        public string NationalIDNumber { get; set; }
        public int? ContactID { get; set; }
        public string LoginID { get; set; }
        public int? ManagerID { get; set; }
        public string Title { get; set; }
        public DateTime? BirthDate { get; set; }
        public string MaritalStatus { get; set; }
        public string Gender { get; set; }
        public DateTime? HireDate { get; set; }
        public int? SalariedFlag { get; set; }
        public bool CurrentFlag { get; set; }

        public virtual ContactGetDTO Contact { get; set; }
    }
}