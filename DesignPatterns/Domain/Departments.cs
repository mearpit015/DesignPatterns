using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DesignPatterns
{
    public partial class Departments
    {
        [Key]
        public int DeptId { get; set; }
        public string DeptName { get; set; }

        /// <summary>
        /// one to many relationship.
        /// </summary>
        public ICollection<Employees> Employees { get; set; }
    }
}
