using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodSubmission
{
    class Program
    {
        static void Main()
        {
            NumberClass numberClass = new NumberClass(); //instantiate the class NumberClass 
            int input1; //delares the  int variable input1
            while (true) //continues to loop until the user enters a correct integer input
            {
                Console.Write("Enter a number to be used in the math operation. "); //writes instructions to the console
                string input1String = Console.ReadLine(); //reads the input from the user and asigns it to string variable input1String
                if (int.TryParse(input1String, out input1)) //conditional statement to try to parse the users input into an integer
                {
                    break; //this will exit the loop if the input is successfully parsed
                }
                Console.WriteLine("Invalid Input. Please enter a valid integer. "); //writes to console this error statement
            }
            Console.WriteLine("Enter another number to be used in the math operation (press Enter if you don't want to enter anything): "); //writes instructions
                                                                                                                                            //to the console
            string input2String = Console.ReadLine(); //reads the input from the user and asigns it to string variable input2String
            int input2 = 0; //if the user presses enter without entering anything, set input2 to zero
            if (!string.IsNullOrEmpty(input2String)) //if user enters a value other than null this condition is and met the while loop will execute
            {
                while (!int.TryParse(input2String, out input2)) //continues to loop until the user enters null or a valid integer
                {
                    Console.WriteLine("Invalid input. Please enter a vaild integer or leave blank and push enter if you prefer not to use another number in the math operation. "); //writes to console this error statement and rewrite the instruction
                    input2String = Console.ReadLine(); //reads the input from the user and reasigns it to string variable input2String
                }
            }            
            int result = numberClass.MathOperation(input1, input2); //calls the method numberClass and passes in the two parameters
            Console.WriteLine($"The results of the math operations are: {result}"); //writes the results from the method 
            Console.ReadLine(); //holds open console
        }
    }
}
