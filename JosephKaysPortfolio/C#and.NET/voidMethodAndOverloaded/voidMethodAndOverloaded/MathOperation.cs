using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace voidMethodAndOverloaded
{
    public class MathOperation //create a class named MathOperation to begin with but lastly I declared it static
    {
        public void DivideBy2AndOutput(decimal number) //create a void method named DivideBy2AndOutput that outputs an integer
        {
            decimal quotient = number / 2; //define a variable and divide it by 2
            Console.WriteLine($"{quotient} is the result of dividing {number} by 2."); //display the results to the console
        }

        public int MultiplyAndOutput(int num1, int num2, out int result) //create a method with output parameters named MultiplyAndOutput
        {
            result = num1 * num2; //perform multiplication and assign the result to the output parameter
            int addToResult = result + 10;
            return addToResult;
        }

        public void DivideBy2AndOutput(int number) //overload DivideBy2AndOutput method with a different parameter type
        {           
            int quotient = number / 2; //define a variable and divide it by 2
            Console.WriteLine($"{quotient} is the result of dividing {number} by 2."); //display the results to the console 
        }
    }
}
