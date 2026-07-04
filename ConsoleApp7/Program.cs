using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{ class Employee {        
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public string Department { get; set; }
        public Employee() { 
           
        }

    }
    delegate string GetEmployeeName(Employee employee);
    class Repository
    {
        private List<Employee> employees;

        public Repository(List<Employee> employees)
        {
            this.employees = employees;
        }

        public List<Employee> GetHighSalaryEmployees(double salary)
        {
            return employees
                   .Where(e => e.Salary > salary)
                   .ToList();
        }
    }
    internal class Program
    {
        static string PrintEmployeeName(Employee employee)
        {
            return employee.Name;
        }


        static void Main(string[] args)

        {
           

            List<Employee> employees = new List<Employee>()
            {
                new Employee { Id = 1, Name = "John", Salary = 50000, Department = "It" },
                new Employee { Id = 2, Name = "Georgette", Salary = 60000, Department = "HR" },
                new Employee { Id = 3, Name = "Mary", Salary = 70000, Department = "Finance" },
                new Employee { Id = 4, Name = "Peter", Salary = 20000, Department = "HR" },
                new Employee { Id = 5, Name = "David", Salary = 80000, Department = "It" } };

            
            

            var itEmployees = employees.Where(e => e.Department == "It").ToList();
            foreach (var e in itEmployees)
            {
                Console.WriteLine($"{e.Name}");
            }

            var highSalary = employees.Where(e => e.Salary > 9000);
                foreach (var employee in highSalary)
                {
                    Console.WriteLine($"Id: {employee.Id}, Name: {employee.Name}, Salary: {employee.Salary}, Department: {employee.Department}");
                }
            var names = employees.Select(e => e.Name).ToList();
            var firstHR= employees.FirstOrDefault(e => e.Department == "HR");
            if (firstHR != null)
            {
                Console.WriteLine($"{firstHR.Name} {firstHR.Salary}");
            }

            var lastSalary = employees.LastOrDefault(e => e.Salary>8000);
            if (lastSalary != null)
            {
                Console.WriteLine($"{lastSalary.Name} {lastSalary.Salary}");
            }
            var ascending = employees.OrderBy(e=> e.Salary).ToList();
            foreach (var e in ascending)
            {
                Console.WriteLine($"{e.Name} {e.Salary}");
            }
            var descending = employees.OrderByDescending(e => e.Salary).ToList();
            foreach (var d in descending)
            {
                Console.WriteLine($"{d.Name} {d.Salary}");
            }
            var any= employees.Any(e => e.Salary > 15000);
            Console.WriteLine(any);
            var all = employees.All(e => e.Department == "It");
            Console.WriteLine(all);
            var count = employees.Count(e => e.Department == "It");
            Console.WriteLine(count);
            Dictionary<int, Employee> employeeDictionary = new Dictionary<int, Employee>()
            {
                { 1, employees[0] },
                { 2,employees[1] },
                { 3,employees[2]},

              
            };
            foreach (var employee in employees) {
                if (employeeDictionary.ContainsKey(1))
                {
               Employee emp= employeeDictionary[1];
                    Console.WriteLine(emp.Name,emp.Salary);

                    //  GetEmployeeName del = PrintEmployeeName;

                    GetEmployeeName del = e => e.Name;

                    Console.WriteLine(del(employees[0]));
                    Repository repo = new Repository(employees);

                    var result = repo.GetHighSalaryEmployees(10000);

                    foreach (var empl in result)
                    {
                        Console.WriteLine($"{empl.Name} {empl.Salary}");
                    }

                }
            }
           
        }
        }
    }

