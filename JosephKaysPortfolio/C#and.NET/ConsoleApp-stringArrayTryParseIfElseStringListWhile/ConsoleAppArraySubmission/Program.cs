using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        //--------------------------------------------------create a one-dimensional array of strings------------------------------------------------------------

        string[] stringArray = { "Apple", "Banana", "Cherry", "Orange", "Grape" }; //create a string type array
        bool validInput = false; //define boolean variable for while loop
        while (!validInput) //begin while loop. the loop will continue until the validInput value is changed to true
        {
            Console.WriteLine("String array example"); //write title to console
            Console.WriteLine(); //skip a line
            Console.WriteLine("Select an index from 0 to 4:"); //write instructions to console
            if (int.TryParse(Console.ReadLine(), out int selectedIndex)) //get input and convert to an int type
            {
                if (selectedIndex >= 0 && selectedIndex < stringArray.Length) //checks if the input is in range
                {
                    Console.WriteLine($"The string at index {selectedIndex} is: {stringArray[selectedIndex]}"); //use '$' to create interpolated
                                                                                                                //strings and write to the console
                    validInput = true; //set to true to exit the loop
                }
                else
                {
                    Console.WriteLine("Invalid index. Please select a valid index between 0 and 4."); //writes an error message to the console
                                                                                                      //and starts loop over
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer."); //writes an error message to the console and starts loop over
            }
        }
        Console.WriteLine(); //skip a line

        //------------------------------------------------create a one-dimensional array of integers------------------------------------------------------------

        int[] intArray = { 10, 20, 30, 40, 50 }; //create a int type array
        bool correctInput = false; //define boolean variable for while loop
        while (!correctInput) //begin while loop. the loop will continue until the correctInput value is changed to true
        {
            Console.WriteLine("Interger array example"); //write title to console
            Console.WriteLine(); //skip a line
            Console.WriteLine("Select an index from 0 to 4:"); //write instructions to console
            if (int.TryParse(Console.ReadLine(), out int indexSelected)) //get input and convert to an int type
            {
                if (indexSelected >= 0 && indexSelected < intArray.Length) //checks if the input is in range
                {
                    Console.WriteLine($"The integer at index {indexSelected} is: {intArray[indexSelected]}"); //use '$' to create interpolated
                                                                                                              //strings and write to the console
                    correctInput = true; //set to true to exit the loop
                }
                else
                {
                    Console.WriteLine("Invalid index. Please select a valid index between 0 and 4."); //writes an error message to the console
                                                                                                      //and starts loop over
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer."); //writes an error message to the console and starts loop over
            }
        }
        Console.WriteLine(); //skip a line

        //--------------------------------------------------------create a list of strings-------------------------------------------------------------------------------

        List<string> stringList = new List<string> { "Red", "Green", "Blue", "Yellow", "Purple" }; //creat a string type list
        bool rightInput = false; //define boolean variable for while loop
        while (!rightInput) //begin while loop. the loop will continue until the rightInput value is changed to true
        {
            Console.WriteLine("String list example"); //write title to console
            Console.WriteLine(); //skip a line
            Console.WriteLine("Select an index from 0 to 4:"); //write instructions to console
            if (int.TryParse(Console.ReadLine(), out int pickedIndex)) //get input and convert to an int type
            {
                if (pickedIndex >= 0 && pickedIndex < stringList.Count) //checks if the input is in range
                {
                    Console.WriteLine($"The string at index {pickedIndex} is: {stringList[pickedIndex]}"); //use '$' to create interpolated
                                                                                                          //strings and write to the console
                    rightInput = true; //set to true to exit the loop
                }
                else
                {
                    Console.WriteLine("Invalid index. Please select a valid index between 0 and 4."); //writes an error message to the console
                                                                                                      //and starts loop over
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer."); //writes an error message to the console and starts loop over
            }
        }
        Console.ReadLine(); //hold console open
    }
}