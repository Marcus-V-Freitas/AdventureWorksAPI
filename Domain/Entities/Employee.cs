using System;

namespace Domain.Entities
{
    public class Employee
    {
        public int? EmployeeID { get; private set; }
        public string NationalIDNumber { get; private set; }
        public int? ContactID { get; private set; }
        public string LoginID { get; private set; }
        public int? ManagerID { get; private set; }
        public string Title { get; private set; }
        public DateTime? BirthDate { get; private set; }
        public string MaritalStatus { get; private set; }
        public string Gender { get; private set; }
        public DateTime? HireDate { get; private set; }
        public int? SalariedFlag { get; private set; }
        public bool CurrentFlag { get; private set; }

        public virtual Contact Contact { get; private set; }
    }
}