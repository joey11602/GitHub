using System;

namespace ConstructorSubmission
{
    class Program
    {
        static void Main()
        {
            //create a const variable
            const string constVariable = " is my name and I'm older than ";

            //instantiate an object of Person class by using the keyword var for my variable
            var newPerson = new Person("Joey");

            //write to console
            Console.WriteLine(newPerson.FirstName + constVariable + newPerson.Age + ".");
            //hold console open
            Console.ReadLine();
            
        }
    }
}
