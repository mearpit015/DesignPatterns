using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DesignPatterns //.Domain
{
    public partial class Employees
    {
        [Key]
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public int EmployeeAge { get; set; }
        public DateTime CreatedDate { get; set; }
        public long Salary { get; set; }
        public int DepartmentDeptId { get; set; }

        // Every employee belongs to a dept. 
        public Departments Department { get; set; }
    }
}
