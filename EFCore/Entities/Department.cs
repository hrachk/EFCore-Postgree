using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Entities
{
    public class Department
    {
        public int DepartmentId { get; set; } 
        public string? DepartmentName { get; set; }    

       
     //   public ICollection<Person>? Persons { get; set; }


    }
}
