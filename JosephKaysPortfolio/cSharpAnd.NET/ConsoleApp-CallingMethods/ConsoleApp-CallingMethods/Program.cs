using System;

class Program
{
    static void Main(string[] args)
    {
        MathOperations mathOps = new MathOperations(); //create an instance of the MathOperations class

        bool validInput = false; //sets false condition to control the while loop

        while (!validInput) //while loop that will continue until the user enters a vaild integer
        {
            try //begin try block to handle exceptions
            {
                Console.WriteLine("Enter a whole number to be used in the math operations:"); //writes user instructions to console

                int userInput = Convert.ToInt32(Console.ReadLine()); //converts users input to an integer and saves it as userInput

                Console.WriteLine($"Result of addition: {mathOps.addTen(userInput)}"); //calls addTen() and writes result to console

                Console.WriteLine($"Result of multiplication: {mathOps.timesTwo(userInput)}"); //calls timesTwo() and writes result to console

                Console.WriteLine($"Result of subtraction: {mathOps.minusFive(userInput)}"); //calls minusFive() and writes result to console

                validInput = true; //changes condition to true to exit while loop
            }
            catch (FormatException) //exception to catch and stop the program from having an error
            {
                Console.WriteLine("Invalid input. Please enter a valid interger."); //error message that is written to the console for the catch
            }
            catch (Exception ex) //exception to catch and stop the program from having an error
            {
                Console.WriteLine($"An error occurred: {ex.Message}"); //error message that is written to the console for the catch
            }
        }
        Console.ReadLine(); //keeps console open to view results
    }
}

