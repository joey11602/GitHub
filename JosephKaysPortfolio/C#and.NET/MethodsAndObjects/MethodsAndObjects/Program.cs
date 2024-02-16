using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee person = new Employee(); //instantiate the class Employee
            person.FirstName = "Sample"; //set the first name of the Employee to "Sample"
            person.LastName = "Student"; //set the last name of the Employee to "Student"
            person.SayName(); //call the method SayName
            Console.ReadLine(); //hold the console open

        }
    }
}
