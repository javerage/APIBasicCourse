using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContosoUniversity.Domain.Entities.Base;

namespace ContosoUniversity.Domain.Entities
{
    public class Course : BaseEntity
    {
        public int Credits { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}