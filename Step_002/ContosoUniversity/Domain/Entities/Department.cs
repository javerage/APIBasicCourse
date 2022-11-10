using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContosoUniversity.Domain.Entities.Base;

namespace ContosoUniversity.Domain.Entities
{
    public class Department : BaseEntity
    {
        public double Budget { get; set; }
        public int InstructorId { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateTime StartDate { get; set; }
    }
}