using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaSubmission
{
    class Program
    {
        static void Main()
        {
            List<Employee> employees = new List<Employee> //create a new list of employees and fill it with ten employees
            {
                new Employee { Id = 1, FirstName = "John", LastName = "Doe" },
                new Employee { Id = 2, FirstName = "Jane", LastName = "Smith" },
                new Employee { Id = 3, FirstName = "Joe", LastName = "Johnson" },
                new Employee { Id = 4, FirstName = "Jack", LastName = "Brown" },
                new Employee { Id = 5, FirstName = "Joe", LastName = "Miller" },
                new Employee { Id = 6, FirstName = "Alice", LastName = "Jones" },
                new Employee { Id = 7, FirstName = "Bob", LastName = "Williams" },
                new Employee { Id = 8, FirstName = "Charlie", LastName = "Davis" },
                new Employee { Id = 9, FirstName = "Emily", LastName = "Moore" },
                new Employee { Id = 10, FirstName = "Frank", LastName = "Taylor" },
            };
            
            List<Employee> joesList = new List<Employee>(); //create a new list of employees with the first name "Joe"
            
            foreach (var employee in employees) //use this foreach loop to filter employees with the first name "Joe"
            {
                if (employee.FirstName == "Joe") //conditional statement to check for first name "Joe"
                {
                    joesList.Add(employee); //add emplyees with "Joe" first name to list
                }
            }
            
            Console.WriteLine("List of Employees with the First Name 'Joe':"); //write to console this header
            foreach (var joeEmployee in joesList) //use this for loop to write each employee with "Joe" to the console
            {
                Console.WriteLine($"ID: {joeEmployee.Id}, Name: {joeEmployee.FirstName} {joeEmployee.LastName}"); //write to console
            }
            
            Console.WriteLine(new string('-', 68)); //print a separator
            
            List<Employee> joesLambdaList = employees.FindAll(x => x.FirstName == "Joe"); //use a lambda expression to create a new list of
                                                                                          //employees with the first name "Joe"

            
            Console.WriteLine("List of Employees with the First Name 'Joe' using Lambda Expression:"); //write to console this header
            foreach (var joeEmployee in joesLambdaList) //use this for loop to write each employee with "Joe" to the console
            {
                Console.WriteLine($"ID: {joeEmployee.Id}, Name: {joeEmployee.FirstName} {joeEmployee.LastName}"); //write to console
            }
            
            Console.WriteLine(new string('-', 68)); //print a separator
            
            List<Employee> greaterThan5List = employees.FindAll(y => y.Id > 5); //use a lambda expression to create a new list of employees
                                                                                //with an Id greater than 5

            
            Console.WriteLine("List of Employees with an Id Greater Than 5 using Lambda Expression:"); //write to console this header
            foreach (var employee in greaterThan5List) //use this for loop to write each employee with Id greater than 5 to the console
            {
                Console.WriteLine($"ID: {employee.Id}, Name: {employee.FirstName} {employee.LastName}"); //write to console
            }
            Console.ReadLine(); //hold open the console
        }
    }
}
