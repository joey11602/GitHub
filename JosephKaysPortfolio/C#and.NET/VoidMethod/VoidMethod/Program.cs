using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethod
{
    class Program
    {
        static void Main()
        {            
            MathOperation mathOperation = new MathOperation(); //instantiate the MathOperation class
                                                               
            mathOperation.PerformOperation(3, 5); //call the PerformOperation method and pass in two parameters

            mathOperation.PerformOperation(firstNumber: 7, secondNumber: 10); //call the PerformOperation method and pass in two parameters by name

            Console.ReadLine(); //hold console open
        }
    }
}
