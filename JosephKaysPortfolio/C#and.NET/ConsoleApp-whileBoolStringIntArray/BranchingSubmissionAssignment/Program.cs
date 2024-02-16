using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below."); //write header to the console
            Console.WriteLine("Please enter the package weight:"); //write instructions to the console
            int weight; // this line declares a int variable
            while (!int.TryParse(Console.ReadLine(), out weight)) // this while loop continues as long as the result is true. by
                                                                  // using the 'not' logic the parsing must succeed to get a false
                                                                  // result and move past it. Until then the user is prompted to enter a valid number.
            {
                Console.WriteLine("Invalid input. Please enter a valid number for the weight."); //writes error message to the console
            }
            if (weight > 50) //if statement will check the weight given and if over 50,run code in if block            {
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day"); //write error message to console
                Console.ReadLine(); //pause for user to hit enter
                return; //terminates the program
            }
            Console.WriteLine("Please enter the package width:"); //write instructions to the console
            int width; // this line declares a int variable
            while (!int.TryParse(Console.ReadLine(), out width)) // this while loop continues as long as the result is true. by
                                                                  // using the 'not' logic the parsing must succeed to get a false
                                                                  // result and move past it. Until then the user is prompted to enter a valid number.
            {
                Console.WriteLine("Invalid input. Please enter a valid number for the width."); //writes error message to the console
            }
            Console.WriteLine("Please enter the package height:"); //write instructions to the console
            int height; // this line declares a int variable
            while (!int.TryParse(Console.ReadLine(), out height)) // this while loop continues as long as the result is true. by
                                                                 // using the 'not' logic the parsing must succeed to get a false
                                                                 // result and move past it. Until then the user is prompted to enter a valid number.
            {
                Console.WriteLine("Invalid input. Please enter a valid number for the height."); //writes error message to the console
            }
            Console.WriteLine("Please enter the package length:"); //write instructions to the console
            int length; // this line declares a int variable
            while (!int.TryParse(Console.ReadLine(), out length)) // this while loop continues as long as the result is true. by
                                                                  // using the 'not' logic the parsing must succeed to get a false
                                                                  // result and move past it. Until then the user is prompted to enter a valid number.
            {
                Console.WriteLine("Invalid input. Please enter a valid number for the length."); //writes error message to the console
            }
            int dimensionsTotal = width + height + length; //equation to calculate the total dimension
            if (dimensionsTotal > 50) //if statement will check the weight given and if over 50,run code in if block            {
            {
                Console.WriteLine("Package too big to be shipped via Package Express. Have a good day"); //write error message to console
                Console.ReadLine(); //pause for user to hit enter
                return; //terminates the program
            }
            decimal cost = ((width * height * length) * weight) / 100; //equation to calculate the total cost
            Console.WriteLine("Your estimated total for shipping this package is: $" + cost); //concatenate string with decimal variable and write to console
            Console.WriteLine("Thank you!"); //write to console
            Console.ReadLine(); //pause for user to hit enter
        }
            
    }
}
