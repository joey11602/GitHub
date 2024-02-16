using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametersAssighnment
{
    class Program
    {
        static void Main()
        {
            // Instantiate an Employee object with type "string"
            Employee<string> stringEmployee = new Employee<string>(new List<string> { "Apple", "Banana", "Orange" });

            // Instantiate an Employee object with type "int"
            Employee<int> intEmployee = new Employee<int>(new List<int> { 1, 2, 3, 4, 5 });

            // Print the Things of the stringEmployee
            Console.WriteLine("Strings:");
            foreach (var thing in stringEmployee.Things)
            {
                Console.WriteLine(thing);
            }

            // Print a separator
            Console.WriteLine(new string('-', 30));

            // Print the Things of the intEmployee
            Console.WriteLine("Integers:");
            foreach (var thing in intEmployee.Things)
            {
                Console.WriteLine(thing);
            }
            Console.ReadLine();
        }
    }
}
