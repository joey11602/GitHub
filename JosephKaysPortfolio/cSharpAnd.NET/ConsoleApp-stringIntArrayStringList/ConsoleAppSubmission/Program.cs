using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            bool condition = true; //define bool variable so the loop will run atleast one time
            while (condition) //while loop to repeat code until condition is false
            {
                Console.WriteLine("Do you want to continue? (yes/no)"); //writes to console
                string userInput = Console.ReadLine(); //takes users input and assigns to variable
                condition = userInput.ToLower() == "yes"; //changes to lower case then compairs the user input to yes,
                                                          //if anything but yes the loop stops
            }
            Console.WriteLine("End of the basic while loop section."); //the loop ends writes to the console and moves
                                                                       //to the next code example
            Console.WriteLine(); //skip a line
            Console.WriteLine("Begins the do/while loop example");
            bool condition2; // initialize the variable condition2 with no value assigned. this is false by default 
            do //begin the do/while loop this will run at least one time even though the default value is false
               //because the while() is at the end
            {
                Console.WriteLine("Do you want to continue? (yes/no)"); //writes to console
                string userInput2 = Console.ReadLine(); //takes users input and ssigns to variable
                condition2 = userInput2.ToLower() == "yes"; //changes to lower case then compairs the user input to yes,
                                                            //if anything but yes the loop stops
            }
            while (condition2); //while() names the variable to be compared in the do/while loop
            Console.WriteLine("End of the do while loop section."); //the loop ends writes to the console
            Console.Read(); //keeps console open
        }
    }
}
