using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjects
{
    public class Person //create the class Person
    {
        public string FirstName { get; set; } //gets or sets the first name of the person
        public string LastName { get; set; } //gets or sets the last name of the person

        public void SayName() //method that displays the full name to the console
        {         
            Console.WriteLine("Name: " + FirstName + " " + LastName); //write to console
        }
    }
}
