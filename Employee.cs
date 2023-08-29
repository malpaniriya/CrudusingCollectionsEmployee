using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudusingCollectionsEmployee
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int Salary { get; set; }

        public string Company { get; set; }
    }

    public class EmployeeCrud
    {
        private List<Employee> employeelist;
        public EmployeeCrud()
        {
            employeelist = new List<Employee>()
            {
                new Employee { Id = 1, Name = "Riya Malpani", Salary = 50000, Company = "Larsen & Tubro" },
               new Employee { Id = 2, Name = "Yash Shah", Salary = 40000, Company = "Infosys" }
            };
        }

        public List<Employee> GetEmployees()
        {
            return employeelist;
        }

        public Employee GetEmployeeById(int id)
        {
            Employee employee = new Employee();
            foreach (Employee e in employeelist)
            {
                if (e.Id == id)
                {
                    employee = e;
                    break;
                }
            }
            return employee;
        }

        public void AddEmployee(Employee e)
        {
            employeelist.Add(e);
        }
        public void UpdateEmployee(Employee e)
        {
            foreach (Employee employee in employeelist)
            {
                if (employee.Id == e.Id)
                {
                    employee.Name = e.Name;
                    employee.Company = e.Company;
                    employee.Salary = e.Salary;
                    break;
                }
            }
        }
        public void DeleteEmployee(int id)
        {
            foreach (Employee employee in employeelist)
            {
                if (employee.Id == id)
                {
                    employeelist.Remove(employee);
                    break;
                }
            }
        }



    }
}

