using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace voidMethodAndOverloaded
{
    class Program
    {
        static void Main()
        {
            MathOperation mathOperation  = new MathOperation(); //instantiate the class MathOperation

            decimal input1; //declare a variable to be used for the output of TryParse
            while (true) //this while loop is to loop until the user inputs a valid number
            {
                Console.WriteLine("Please enter a number: "); //writes instructions to the console
                string userInput1 = Console.ReadLine(); //assigns the users input to a variable
                if (decimal.TryParse(userInput1, out input1)) //conditional if statement to try to parse the input to a decimal value
                {
                    break; //exits the while loop
                }
                Console.WriteLine("Invalid Input. Please enter a valid number. "); //writes error message to console
            }
            mathOperation.DivideBy2AndOutput(input1); //calls the method DivideBy2AndOutput and passes in 'input1'

            int input2; //declares a variable to be used for the output of TryParse
            int input3; //declares another variable to be used for the output of TryParse
            while (true) //this while loop is to loop until the user inputs a valid number
            {
                Console.WriteLine("Please enter a whole number: "); //writes instructions to the console
                string userInput2 = Console.ReadLine(); //assigns the users input to a variable
                if (int.TryParse(userInput2, out input2)) //conditional if statement to try to parse the input to an integer value
                {
                    break; //exits the while loop
                }
                Console.WriteLine("Invalid Input. Please enter a valid whole number. "); //writes error message to console
            }
            while (true) //this while loop is to loop until the user inputs a valid second number
            {
                Console.WriteLine("Please enter another whole number: "); //writes instructions to the console
                string userInput3 = Console.ReadLine(); //assigns the users input to a variable
                if (int.TryParse(userInput3, out input3)) //conditional if statement to try to parse the input to a integer value
                {
                    break; //exits the while loop
                }
                Console.WriteLine("Invalid Input. Please enter a valid whole number. "); //writes error message to console
            }
            int addToResult = mathOperation.MultiplyAndOutput(input2, input3, out int result); //calls the method MultiplyAndOutput
                                                                                               //and assigns the rusult to 'addToResult'
            Console.WriteLine($"{input2} times {input3} equals {result}"); //writes to the console
            Console.WriteLine($"{result} plus 10 equals {addToResult}"); //writes to the console

            bool isValidInput = false; //define a boolean qualifying statement to be used to control the ending of the while loop
            int input4; //declares a variable to be used for the output of TryParse

            while (!isValidInput) //this while loop will loop until the qualifying statement gets changed to true
            {
                Console.WriteLine("Please enter a even whole number: "); //writes instructions to the console
                string userInput4 = Console.ReadLine(); //assigns the users input to a variable
                if (int.TryParse(userInput4, out input4)) //conditional if statement to try to parse the input to an integer value
                {                    
                    if (input4 % 2 == 0) //check if the input is an even integer
                    {
                        isValidInput = true; //change qualifying statemnt to true that will end the while loop
                        mathOperation.DivideBy2AndOutput(input4); //calls the method DivideBy2AndOutput and passes in 'input4'
                    }
                    else //conditional statement if the users input was not an equal number
                    {
                        Console.WriteLine("Invalid input."); //writes error message to console loop restarts
                    }
                }
                else //conditional statement if the users input would not parse to a integer
                {
                    Console.WriteLine("Invalid input."); //writes error message to console loop restarts
                }
            }

            int result3 = StaticMath.Multiply(3, 5); //calls the static class StaticMath's method 'Multiply' passes in two parameters returns a value to the main
            Console.WriteLine($"3 times 5 equals {result3}"); //writes to console

            Console.ReadLine(); //hold console open
        }
    }
}
