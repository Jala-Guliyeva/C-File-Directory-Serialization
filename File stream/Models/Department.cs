using System;
using System.Collections.Generic;
using System.Text;

namespace File_stream.Models
{
    internal class Department
    {
     
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Employee> Employees { get; set; }

        public Department()
        {
            
            Employees = new List<Employee>();
        }

        public void AddEmployee(Employee employee)
        {
            Employees.Add(employee);

        }
        public Employee GetEmployeesById(int? id)
        {
            return Employees.Find(e=> e.Id == id);
        }

        public void RemoveEmployee(int? id)
        {
            Employee employee = GetEmployeesById(id);
            
            
            Employees.Remove(employee);
        }

    }
}
