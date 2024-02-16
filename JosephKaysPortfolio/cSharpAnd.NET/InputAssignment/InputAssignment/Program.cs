using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace InputAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number."); //prompts the user to input a number
            string userNumber = Console.ReadLine(); //assigns that input to a string variable named userNumber
            string filePath = @"C:\Users\joey3\logs\log.txt"; //assign my file path to a string variable named filePath
            using (StreamWriter file = new StreamWriter(filePath, true)) //using StreamWriter, create an instance of
                                                                         //StreamWriter and pass in filePath and true/append
            {
                file.WriteLine(userNumber); //writes the value of userNumber to my log.txt
            }

            Console.WriteLine("Contents of my text file:"); //write this header to the console
            using (StreamReader reader = new StreamReader(filePath)) //using StreamReader, create an instance of
                                                                     //StreamWriter and pass in filePath
            {
                while (!reader.EndOfStream) //create a wile loop to iterate through each line in my text file
                                            //until the EndOfStream is reached
                {
                    string line = reader.ReadLine(); //reads the line from the text file
                    Console.WriteLine(line); //write to the console the line from the text file
                }
                Console.ReadLine(); //keep the console open;
            }

        }
    }
}
