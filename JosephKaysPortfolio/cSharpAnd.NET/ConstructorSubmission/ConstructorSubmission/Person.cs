
namespace ConstructorSubmission
{
    //create the class Person
    public class Person
    {
        //constructor with the firstName parameter that chains to the
        //second constructor by providing the default age value
        public Person(string firstName) : this(firstName, 21)
        {
        }
        //constructor with the FirstName and Age parameters
        public Person(string firstName, int age)
        {
            //assign values to FirstName and Age
            FirstName = firstName;
            Age = age;
        }
        //gets or sets the first name of the person
        public string FirstName { get; set; }
        //gets or sets the age of the person
        public int Age { get; set; }
    }
}
