using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsSubmissionAssignment
{
    public class Employee
    {
        public int Id { get; set; } //gets or sets the Id of the Employee
        public string FirstName { get; set; } //gets or sets the first name of the Employee
        public string LastName { get; set; } //gets or sets the last name of the Employee

        public static bool operator ==(Employee employee1, Employee employee2) //overloade the equal operator
        {           
            return employee1.Id == employee2.Id; //custom equality comparison for Id
        }

        public static bool operator !=(Employee employee1, Employee employee2) //overload the not equal operator
        {
            return employee1.Id != employee2.Id; //custom inequality comparison for Id
        }
    }
}
