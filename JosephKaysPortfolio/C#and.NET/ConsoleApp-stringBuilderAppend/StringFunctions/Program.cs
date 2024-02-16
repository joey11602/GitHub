using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "Jesse";
            //string quote = "The man said, \"Hello\", Jesse. \nHello on a new line. \n \tHello on a tab."; //showing the use of the escape function "\"
            //string fileName = "C:\\Users\\Jesse"; //the escape must be used to use a back slash inside a string
            //string fileName2 = @"C:\Users\Jesse"; //@ tells the compiler that everything inside the "" is a string
            //Console.WriteLine(quote);
            //Console.WriteLine(fileName);
            //Console.WriteLine(fileName2);

            //bool trueOrFalse = name.Contains("s");
            //Console.WriteLine(trueOrFalse);
            //trueOrFalse = name.EndsWith("s");
            //Console.WriteLine(trueOrFalse);

            //int length = name.Length; //from string variable name "Jesse"
            //Console.WriteLine(length);
            //name = name.ToUpper();
            //Console.WriteLine(name);
            //name = name.ToLower();
            //Console.WriteLine(name);

            //StringBuilder sb = new StringBuilder();
            //sb.Append("My name is Jesse");
            //Console.WriteLine(sb);

            string one = "My name ";
            string two = "is ";
            string three = "Joey!";
            Console.WriteLine(one + two + three);
            three = three.ToUpper();
            Console.WriteLine(three);
            StringBuilder sb = new StringBuilder();
            sb.Append("My name ");
            sb.Append("is ");
            sb.Append("Joey!");
            Console.WriteLine(sb);



            Console.ReadLine();
        }
    }
}
