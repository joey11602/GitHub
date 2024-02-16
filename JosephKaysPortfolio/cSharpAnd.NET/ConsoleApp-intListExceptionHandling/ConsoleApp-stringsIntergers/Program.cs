using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_stringsIntergers
{
    class Program
    {
        static void Main(string[] args)
        {
            try //try block begins for exception handling
            {
                List<int> intergers = new List<int>() { 36, 68, 44, 88, 102, 346 }; //create a int list
                Console.WriteLine("Please input a whole number to divide the intergers in the list by."); //write to the console instructions
                int userNumber = Convert.ToInt32(Console.ReadLine()); //read the console to the variable userNumber
                foreach (int interger in intergers) //for loop to iterate through the list
                {
                    decimal quotient = (decimal)interger / userNumber; //formula to divide the intergers in the list by the userNumber and
                                                                       //get the exact result by using decimal type
                    Console.WriteLine(quotient); //write to console the answer
                }
            }
            catch (DivideByZeroException) //exception to catch and stop the program from having an error
            {
                Console.WriteLine("***ERROR***Please don't try to divide by zero."); //error message that is written to the console for the catch
            }
            catch (FormatException) //exception to catch and stop the program from having an error
            {
                Console.WriteLine("***ERROR***Please input an interger."); //error message that is written to the console for the catch
            }
            finally //the finally statement will run regaurdless if there is an error or not
            {
                Console.WriteLine("This program has emerged from the try catch block and continued with the rest of the code."); //writes to console
                                                                                                                                 //from the finally
                                                                                                                                 //statement
            }
            Console.ReadLine(); //holds the console open
        }
    }
}

