using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity.Domain.Entities
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public DateTime HireDate { get; set; }
        public DateTime? EnrollmentDate { get; set; }
        public string Address { get; set; } = string.Empty;
        public bool? HasParkingLot { get; set; }

    }
}