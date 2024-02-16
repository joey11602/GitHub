using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructAssignment
{
    class Program
    {
        static void Main()
        {
            Number number = new Number { Amount = 5.50m }; //create an instance of the Number struct and assigm its property Amount a value
            Console.WriteLine($"The amount is: {number.Amount}"); //write to the console the amount
            Console.ReadLine(); //hold open the console
        }
    }
}
