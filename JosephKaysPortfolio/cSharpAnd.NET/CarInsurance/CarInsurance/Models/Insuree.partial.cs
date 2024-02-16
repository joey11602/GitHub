using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarInsurance.Models
{
    public partial class Insuree
    {
        //read-only property to calculate age
        public int Age
        {
            get
            {
                DateTime currentDate = DateTime.Now;
                int age = currentDate.Year - DateOfBirth.Year;

                //check if the birthday has occurred this year
                if (currentDate < DateOfBirth.AddYears(age))
                {
                    age--;
                }

                return age;
            }
        }
    }
}