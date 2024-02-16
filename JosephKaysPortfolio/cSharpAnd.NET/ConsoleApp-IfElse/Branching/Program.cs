using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching
{
    class Program
    {
        static void Main(string[] args)
        {
            int currentTemperature = 70;
            int roomTemperature = 70;

            string comparisonResults = currentTemperature == roomTemperature ? "It is room temp." : "It is not room temp.";
            Console.WriteLine(comparisonResults);
            //if (currentTemperature == roomTemperature)
            //{
            //    Console.WriteLine("It is exactly room temperature.");
            //}
            //else if (currentTemperature > roomTemperature)
            //{
            //    Console.WriteLine("It is warmer than room temperature.");
            //}
            //else 
            //{
            //    Console.WriteLine("It is not exactly room temperature.");
            //}
            Console.ReadLine();
        }
    }
}
