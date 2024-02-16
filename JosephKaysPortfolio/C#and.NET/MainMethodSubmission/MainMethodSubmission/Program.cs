using System;

namespace MainMethodSubmission
{
    class Program
    {
        static void Main()
        {
            MathOperations mathOperations = new MathOperations(); //instantiate the MathOperations class

            int intResult = mathOperations.PerformMathOperation(10); //call the first method with an integer
            Console.WriteLine($"Result for integer parameter: {intResult}"); //write to console the result

            int decimalResult = mathOperations.PerformMathOperation(7.5M); //call the second method with a decimal
            Console.WriteLine($"Result for decimal parameter: {decimalResult}"); //write to console the result

            int stringResult = mathOperations.PerformMathOperation("15"); //call the third method with a string that can be converted to an integer
            Console.WriteLine($"Result for string parameter: {stringResult}"); //write to console the result
            Console.ReadLine(); //hold console open
        }
        
    }
}
