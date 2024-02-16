using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogicSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Acme Auto Insurance"); //write title to console
            Console.WriteLine(); //line break
            Console.WriteLine("Answer the following questions so we can see if you are qualified for car insurance."); //write instructions to console
            Console.WriteLine("What is your age? (This must be a numerical entry.)"); //write instructions to console
            float age;
            while (!float.TryParse(Console.ReadLine(), out age)) // this while loop continues as long as the result is true. by using the 'not' logic
                                                                 // the parsing must succeed to get a false result and move past it. Until then, the
                                                                 // user is prompted to enter a valid number.
            {
                Console.WriteLine("Invalid input. Please enter a valid number for your age."); //writes an error to the console and returns user to
                                                                                               //the begining of the while loop
            }
            Console.WriteLine(); //line break
            Console.WriteLine("Have you ever had a DUI ?  Please answer \"true\" or \"false.\""); // this line writes to the console
            bool dui; // this line declares a boolean variable
            while (!bool.TryParse(Console.ReadLine(), out dui)) // this while loop continues as long as the result is true. by using the 'not' logic
            // the parsing must succeed to get a false result and move past it. Until then, the user is prompted to enter true or false.
            {
                Console.WriteLine("Invalid input. Please enter \"true\" or \"false.\"");
            }
            Console.WriteLine(); //line break
            Console.WriteLine("How many speeding tickets do you have? (This must be a numerical entry. Enter 0 for none.)"); //write instructions to console
            float tickets;
            while (!float.TryParse(Console.ReadLine(), out tickets)) // this while loop continues as long as the result is true. by using the 'not' logic
                                                                     // the parsing must succeed to get a false result and move past it. Until then, the
                                                                     // user is prompted to enter a valid number.
            {
                Console.WriteLine("Invalid input. Please enter a valid number for the amount of tickets you have."); //writes an error to the console and returns
                                                                                                                     //user to the begining of the while loop
            }
            Console.WriteLine(); //line break
            bool qualify = (age > 15 && dui == false && tickets < 4); //boolean equation to determine if the applicant qualifies
            Console.WriteLine("Qualified?"); //write to console
            Console.WriteLine(qualify); //write variable qualify to console
            Console.ReadLine(); //keep console open
        }
    }
}
