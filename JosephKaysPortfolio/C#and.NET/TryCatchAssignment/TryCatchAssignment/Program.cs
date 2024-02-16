using System;

namespace TryCatchAssignment
{
    class Program
    {
        static void Main()
        {
            //set boolean flag validInput to false for while loop to continue until changed
            bool validInput = false;
            //write to the console to ask the user their age
            Console.WriteLine("How old are you?");
            //begin while loop as long as validInput is false
            while (!validInput)
            {
                //begin try block to catch any exceptions
                try
                {
                    //read the console input and assign it to string variable input
                    string input = Console.ReadLine();
                    //if statement to try to parse users input into an integer that is valid for this program
                    if (int.TryParse(input, out int userAge) && userAge >0)
                    {
                        //get the year from DateTime and assign it to int variable currentYear
                        int currentYear = DateTime.Now.Year;
                        //subtract userAge from currentYear and assign it to int birthYear
                        int birthYear = currentYear - userAge;
                        //write to the console the users birth year
                        Console.WriteLine("You were born in {0}.", birthYear);
                        //hold the console open until user pushes enter
                        Console.ReadLine();
                        //change boolean flag to true to terminate the while loop
                        validInput = true;
                    }
                    //else statement that will throw an exception if the TryParse fails or if the userAge is not > then 0
                    else
                    {
                        throw new FormatException();
                    }
                }
                //catch block to catch for FormatException
                catch (FormatException)
                {
                    //write to the console to prompt the user for the correct format
                    Console.WriteLine("Invalid input. Please enter a valid age as a number.");
                }
                //catch block to catch any other Exception
                catch (Exception)
                {
                    //write to the console that an error occured and to contact their System Admin
                    Console.WriteLine("An error occurred. Please contact your System Administrator.");
                    //hold the console open until user pushes enter
                    Console.ReadLine();
                    //this will terminate the program since it is a void type
                    return;
                }
            }
        }
    }
}
