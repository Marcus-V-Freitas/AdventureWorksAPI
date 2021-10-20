using System;

namespace Domain.Entities
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string NationalIDNumber { get; set; }
        public int ContactID { get; set; }
        public string LoginID { get; set; }
        public int ManagerID { get; set; }
        public string Title { get; set; }
        public DateTime BirthDate { get; set; }
        public string MaritalStatus { get; set; }
        public string Gender { get; set; }
        public DateTime HireDate { get; set; }
        public int SalariedFlag { get; set; }
        public int CurrentFlag { get; set; }

        public virtual Contact Contact { get; set; }
    }
}