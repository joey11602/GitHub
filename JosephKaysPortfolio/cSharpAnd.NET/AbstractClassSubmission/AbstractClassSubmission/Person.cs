using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassSubmission
{
    public abstract class Person //create the public abstract class Person
    {
        public string firstName { get; set; } //gets or sets the first name of the person
        public string lastName { get; set; } //gets or sets the last name of the person

        public abstract void SayName(); //create an abstract void method called SayName
    }
}
