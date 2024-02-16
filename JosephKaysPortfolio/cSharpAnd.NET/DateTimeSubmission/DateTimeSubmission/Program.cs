using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime currentDateTime = DateTime.Now; //get the date and time at this very moment and assign it to currentDateTime
            Console.WriteLine(DateTime.Now); //write to console the variable currentDateTime
            Console.WriteLine("Please enter a whole number."); //prompt the user to input a whole number
            string userInput = Console.ReadLine(); //assign the users input to userInput
            int userNumber = Convert.ToInt32(userInput); //convert the string data to an integer
            DateTime hoursAddeddateTime = currentDateTime.AddHours(userNumber); //add user number in hours to currentDateTime and
                                                                                //assign it to hoursAddeddateTime
            Console.WriteLine($"The DateTime is: {hoursAddeddateTime} after adding {userNumber} hours to it.");
            //write to the console the date and time with the users number in hours added to it
            Console.ReadLine(); //hold console open
        }
    }
}
