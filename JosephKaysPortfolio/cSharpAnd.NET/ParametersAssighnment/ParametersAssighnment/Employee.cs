using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametersAssighnment
{
    public class Employee<T>
    {
        // Property to hold a generic list matching the type parameter
        public List<T> Things { get; set; } = new List<T>(); // Initialize with an empty list

        // Constructor to initialize the Things property
        public Employee(List<T> things)
        {
            Things = things;
        }
    }
}
