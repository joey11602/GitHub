using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethod
{
    class MathOperation //create a class
    {
        public void PerformOperation(int firstNumber, int secondNumber) //create a void method that takes two parameters
        {
            int result = firstNumber * 2; //perform a math operation on the first parameter and assign it to int variable result
                                          //(***does not say to display this***)
            Console.WriteLine($"Second Number: {secondNumber}"); //display the second parameter to the console screen 
        }
    }
}
