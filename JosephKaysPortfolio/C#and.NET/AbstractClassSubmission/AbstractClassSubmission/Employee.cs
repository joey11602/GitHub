using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassSubmission
{
    class Employee : Person, IQuittable
    {
        public  override void SayName() //implement and override the abstract void method called SayName from the base class Person
        {
            Console.WriteLine("Name: " + firstName + " " + lastName); //write to console
        }
        public void Quit() //implement the method Quit() from the interface IQuittable
        {
            Console.WriteLine("Employee is quitting..."); //write to console
        }
    }
}
