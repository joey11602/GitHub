using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReportAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // this block of code will ask the user in the console the questions for the daily report
            // the answers will be saved into memory as the variables that are assigned
            Console.WriteLine("The Tech Academy\nStudent Daily Report"); // this line writes to the console

            Console.WriteLine("What is your name?"); // this line writes to the console
            string studentName = Console.ReadLine(); // this line save the user input as a string

            Console.WriteLine("What course are you on?"); // this line writes to the console
            string courseName = Console.ReadLine(); // this line saves the user input as a string

            Console.WriteLine("What page number are you on?"); // this line writes to the console
            int pageNumber; // this line declares a int variable
            while (!int.TryParse(Console.ReadLine(), out pageNumber)) // this while loop continues as long as the result is true. by using the 'not' logic
            // the parsing must succeed to get a false result and move past it. Until then, the user is prompted to enter a valid number.
            {
                Console.WriteLine("Invalid input. Please enter a valid number for the page.");
            }

            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false.\""); // this line writes to the console
            bool parsedNeedHelp; // this line declares a boolean variable
            while (!bool.TryParse(Console.ReadLine(), out parsedNeedHelp)) // this while loop continues as long as the result is true. by using the 'not' logic
            // the parsing must succeed to get a false result and move past it. Until then, the user is prompted to enter true or false.
            {
                Console.WriteLine("Invalid input. Please enter \"true\" or \"false.\"");
            }

            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics."); // this line writes to the console
            string posExperiences = Console.ReadLine(); // this line saves the user input as a string

            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific."); // this line writes to the console 
            string feedBack = Console.ReadLine(); // this line saves the user input as a string

            Console.WriteLine("How many hours did you study today?"); // this line writes to the console
            int numberOfHours; // this line declares a int variable
            while (!int.TryParse(Console.ReadLine(), out numberOfHours)) // this while loop continues as long as the result is true. by using the 'not' logic
            // the parsing must succeed to get a false result and move past it. Until then, the user is prompted to enter a valid number.
            {
                Console.WriteLine("Invalid input. Please enter a valid number for the hours.");
            }

            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!"); //this writes to the console
            // end of program

            // I wrote this to check my variables and logic
            Console.WriteLine("\nName: " + studentName);
            Console.WriteLine("Course: " + courseName);
            Console.WriteLine("Page:" + pageNumber);
            Console.WriteLine("Need Help: " + parsedNeedHelp);
            Console.WriteLine("Positive Experiences: " + posExperiences);
            Console.WriteLine("Feedback: " + feedBack);
            Console.WriteLine("Hours of Study: " + numberOfHours);

            // this holds the console open until I close it
            Console.ReadLine();
        }
    }
}
