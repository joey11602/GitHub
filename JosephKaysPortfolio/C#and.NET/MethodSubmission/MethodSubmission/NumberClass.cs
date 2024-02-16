using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodSubmission
{
    class NumberClass //create the class NumberClass
    {
        public int MathOperation(int number, int addNum = 1) //create a method to add the first number
                                                                 //by the second number or use its default value
        {
            int result = number + addNum; //declare the int result and make it equal to the equation
            return result; //return rusult to main program
        }
    }
}
