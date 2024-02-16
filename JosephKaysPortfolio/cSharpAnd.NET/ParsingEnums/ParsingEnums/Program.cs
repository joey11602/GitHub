using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnums
{
    class Program
    {
        enum DaysOfWeek //create an enum for the days of the week
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }
        static void Main()
        {
            bool validInput = false; //define boolean variable for while loop
            while (!validInput) //begin while loop. the loop will continue until the validInput value is changed to true
            {
                try //try block to use to try to parse the users input
                {
                    Console.Write("Enter the current day of the week: "); //prompt the user to enter the current day of the week
                    string userInput = Console.ReadLine(); //assign user input to a string variable userInput
                    DaysOfWeek userDay = (DaysOfWeek)Enum.Parse(typeof(DaysOfWeek), userInput, true);
                    //assign to DaysOfWeek type variable 'userDay' the result of parsing the 'userInput'---we cast the Enum.Parse result to one of the DaysOfWeek
                    //enum---it takes three parameters---the typeof, the userInput to be parsed and a boolean for case-insensitive/true case-sensitive/false
                    Console.WriteLine($"You entered: {userDay}"); //writes the day to the console
                    validInput = true; //set to true to exit the loop
                }
                catch (ArgumentException) //if the user inputs something other than what is in the DaysOfWeek enum this catch block will catch the
                                          //ArgumentException thrown and promt the user
                {                  
                    Console.WriteLine("Only an actual day of the week will be accepted as valid input."); //writes to the console to inform the user of the error
                }
                catch (Exception ex) //handles any other exceptions
                {                   
                    Console.WriteLine($"An error occurred: {ex.Message}"); //writes to the console the error and exits the program
                    break;
                }
            }
            Console.ReadLine(); //holds the console open
        }
    }
}
