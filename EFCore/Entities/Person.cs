using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Entities
{
    public class Person
    {
        public int Id { get; set; } 
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public int Age { get; set; }
        public int DepartmentId { get; set; }
        public Department? Department { get; set; }
    }
}
