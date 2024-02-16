using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparisonOperatorAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program"); //print program name
            Console.WriteLine(); //line break
            Console.WriteLine("Person 1"); //person 1 input
            Console.WriteLine("Enter the hourly rate with two decimals to the right of the decimal point."); //ask for user input (hourly Rate)
            float per1HourlyRate;
            while (!float.TryParse(Console.ReadLine(), out per1HourlyRate)) // this while loop continues as long as the result is true. by using the 'not' logic
            // the parsing must succeed to get a false result and move past it. Until then, the user is prompted to enter a valid number.
            {
                Console.WriteLine("Invalid input. Please enter a valid number for the hourly rate with two decimals to the right of the decimal point."); //gives the user an error message
            }
            Console.WriteLine("Enter the number of hours worked per week with two decimals to the right of the decimsl point."); //ask for user input (hours worked per week)
            float per1HoursWorked;
            while (!float.TryParse(Console.ReadLine(), out per1HoursWorked)) // this while loop continues as long as the result is true. by using the 'not' logic
            // the parsing must succeed to get a false result and move past it. Until then, the user is prompted to enter a valid number.
            {
                Console.WriteLine("Invalid input. Please enter a valid number for the hourly rate with two decimals to the right of the decimal point."); //gives the user an error message
            }

            Console.WriteLine(); //line break

            Console.WriteLine("Person 2"); //person 1 input
            Console.WriteLine("Enter the hourly rate with two decimals to the right of the decimal point."); //ask for user input (hourly Rate)
            float per2HourlyRate;
            while (!float.TryParse(Console.ReadLine(), out per2HourlyRate)) // this while loop continues as long as the result is true. by using the 'not' logic
            // the parsing must succeed to get a false result and move past it. Until then, the user is prompted to enter a valid number.
            {
                Console.WriteLine("Invalid input. Please enter a valid number for the hourly rate with two decimals to the right of the decimal point."); //gives the user an error message
            }
            Console.WriteLine("Enter the number of hours worked per week with two decimals to the right of the decimsl point."); //ask for user input (hours worked per week)
            float per2HoursWorked;
            while (!float.TryParse(Console.ReadLine(), out per2HoursWorked)) // this while loop continues as long as the result is true. by using the 'not' logic
            // the parsing must succeed to get a false result and move past it. Until then, the user is prompted to enter a valid number.
            {
                Console.WriteLine("Invalid input. Please enter a valid number for the hourly rate with two decimals to the right of the decimal point."); //gives the user an error message
            }

            Console.WriteLine(); //line break

            Console.WriteLine("Annual salary Person 1:"); //print header
            double salaryPerson1 = per1HourlyRate * per1HoursWorked * 52; //equation for annual salary
            string strSalaryPerson1 = salaryPerson1.ToString(); //convert double to string
            Console.WriteLine("$ " + strSalaryPerson1); //print formatted person1 salary

            Console.WriteLine(); //line break

            Console.WriteLine("Annual salary Person 2:"); //print header
            double salaryPerson2 = per2HourlyRate * per2HoursWorked * 52; //equation for annual salary
            string strSalaryPerson2 = salaryPerson2.ToString(); //convert double to string
            Console.WriteLine("$ " + strSalaryPerson2); //print formatted person2 salary

            Console.WriteLine(); //line break

            Console.WriteLine("Does Person 1 make more money than Person 2?"); //print question
            bool answer = salaryPerson1 > salaryPerson2; //assign variable to boolean logical equation
            Console.WriteLine(answer); //print answer
            Console.ReadLine(); //hold console open

    
        }
    }
}
