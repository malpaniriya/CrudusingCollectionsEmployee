using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudusingCollectionsEmployee
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            int no = 0;
            EmployeeCrud crud = new EmployeeCrud();
            do
            {
                Console.WriteLine("\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\");
                Console.WriteLine("1. Employee List");
                Console.WriteLine("2. Get Employee by Id");
                Console.WriteLine("3.Add Employee");
                Console.WriteLine("4.Update Employee");
                Console.WriteLine("5.Delete Employee");
                Console.WriteLine("Select the option");
                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        List<Employee> list = crud.GetEmployees();
                        Console.WriteLine("Id \t Name \t Salary \t Comapany\t");
                        foreach (Employee emp in list)
                        {
                            Console.WriteLine($"{emp.Id} {emp.Name} {emp.Salary} {emp.Company}");
                        }
                        break;
                    case 2:
                        Console.WriteLine("Enter the Employee Id");
                        int id = Convert.ToInt32(Console.ReadLine());
                        Employee e = crud.GetEmployeeById(id);
                        Console.WriteLine("Id \t Name \t Salary \t Comapany \t");
                        Console.WriteLine($"{e.Id} {e.Name} {e.Salary} {e.Company}");
                        break;
                    case 3:
                        Employee e1 = new Employee();
                        Console.WriteLine("Enter Employee Id");
                        e1.Id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Employee Name");
                        e1.Name = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("Enter Employee Salary");
                        e1.Salary = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the Company Name");
                        e1.Company = Convert.ToString(Console.ReadLine());
                        crud.AddEmployee(e1);
                        Console.WriteLine("Data Saved...");
                        break;
                    case 4:
                        Employee e2 = new Employee();
                        Console.WriteLine("Enter Employee Id");
                        e2.Id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Employee Name");
                        e2.Name = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("Enter Employee Salary");
                        e2.Salary = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the Company Name");
                        e2.Company = Convert.ToString(Console.ReadLine());
                        crud.AddEmployee(e2);
                        Console.WriteLine("Data Saved...");
                        break;
                    case 5:
                        Console.WriteLine("Enter the Employee Id");
                        int id2 = Convert.ToInt32(Console.ReadLine());
                        crud.DeleteEmployee(id2);
                        Console.WriteLine($"{id2} empoyee deleted...");
                        break;
                }

                Console.WriteLine("Press 1 to Continue");
                no = Convert.ToInt32(Console.ReadLine());
            }
            while (no == 1);





        }
    }
}
    

