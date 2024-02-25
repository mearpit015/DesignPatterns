using DesignPatterns;//.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class Repository
    {
        public void AddDepartment(string deptName)
        {
            using (var context = new DomainContext())
            {

                var existingDept = context.Departments.FirstOrDefault(x => x.DeptName == deptName);
                if (existingDept is null)
                {
                    Departments departments = new Departments()
                    {
                        DeptName = deptName
                    };

                    context.Departments.Add(departments);
                    context.SaveChanges();
                }

            }
        }

        public void AddEmployee()
        {
            try
            {
                using (var context = new DomainContext())
                {

                    Employees employees = new Employees()
                    {
                        CreatedDate = DateTime.Now,
                        EmployeeAge = 28,
                        EmployeeName = "Rahul",
                        Salary = 20000,
                        DepartmentDeptId = 1,
                    };

                    context.Employees.Add(employees);
                    context.SaveChanges();
                }
            }
            catch(Exception ex)
            {

            }
        }

        public void AddBoth()
        {
            try
            {
                // If error occurs no record is going to insert in the same scope.
                // each table first create insert query, Then next Select statement on the same table to get primaryKey Id in the entity object using 
                // example after insert dept => select DeptId from Departments where @@RowCount = 1 AND Id = @ScopeIdentity.
                using (var context = new DomainContext())
                {

                    Departments departments = new Departments()
                    {
                        DeptName = "QA"
                    };

                    context.Departments.Add(departments);

                    Employees employees = new Employees()
                    {
                        CreatedDate = DateTime.Now,
                        EmployeeAge = 28,
                        EmployeeName = "Rakesh",
                        Salary = 30000,
                        DepartmentDeptId = 8
                    };

                    context.Employees.Add(employees);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }            
        }

    }
}
