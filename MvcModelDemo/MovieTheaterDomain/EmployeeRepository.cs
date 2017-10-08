using System;
using System.Collections.Generic;
using System.Linq;

namespace MovieTheaterDomain
{
    public class EmployeeRepository
    {
        public IQueryable<Employee> FindAll()
        {
            return _employees.AsQueryable();
        }

        public Employee FindByID(int id)
        {
            return _employees.Where(e => e.ID == id).FirstOrDefault();
        }

        public void Save(Employee employee)
        {
            var existingEmployee = _employees.Where(e => e.ID == employee.ID).FirstOrDefault();
            if (existingEmployee == null)
            {
                _employees.Add(employee);
            }
        }

        #region Source
        // for demo purposes only
        static List<Employee> _employees = new List<Employee>
        {
            new Employee() { ID=1, Name="Scott", HireDate=new DateTime(2001,10,15) },
            new Employee() { ID=2, Name="Poonam", HireDate=new DateTime(2001, 3, 10) }
        };
        #endregion
    }
}
