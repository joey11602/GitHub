using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsSubmissionAssignment
{
    class Program
    {
        static void Main()
        {
            Employee employee1 = new Employee { Id = 0, FirstName = "John", LastName = "Doe" }; //instantiate an Employee object
            Employee employee2 = new Employee { Id = 1, FirstName = "Joe", LastName = "Jackson" }; //instantiate another Employee object
            bool areEqual = employee1 == employee2; //compare objects with overloaded operator ==
            Console.WriteLine($"Are the employee IDs equal? {areEqual}"); //write the result to the console
            Console.ReadLine(); //hold the console open
        }
    }
}
