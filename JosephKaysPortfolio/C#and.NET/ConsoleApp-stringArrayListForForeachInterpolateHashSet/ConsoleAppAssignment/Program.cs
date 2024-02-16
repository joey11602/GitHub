using System;
using System.Collections.Generic;

namespace ConsoleAppAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            /*I started working on this assignment Saturday, there was no way to send an email and ask for clarification. I didn't want to waste
            the whole weekend and not do anything. My approach is this.....I did part one and used a for loop that iterated using i and a < operator.
            I was then tasked in part two to add an infinite loop. It didn't make much sense but I did it anyhow and it looped over the entire program 
            so the user could keep adding strings to be appended to the array forever if they didn't manually terminate the program. Part three asked 
            me to use the < and then the <= operators so I used the < for the appending and I used the <= for the printing. Made sense to me but then 
            I came to part four and this created a dilemma for me. What do I do with this infinite loop. I have learned now to do exactly what the 
            requirements say. In the past, I have not paid attention on several assignments only to have to re-do them. So if I have to re-do this, 
            so be it, but I am trying to not waste the whole week end. I chose to add a prompt at the end of all the added parts of this console app 
            for the user to enter an infinite loop if they so chose. This way my program is not interfered with by the infinite loop and you guys can 
            see that I understand how an infinite loop works. It is my hope that this still meets all the requirements.*/

            string[] fruits = { "Apple", "Banana", "Cherry", "Orange", "Grape" }; //create a string type array
            Console.WriteLine("Please input some text."); //prompts the user to input some text
            string userText = Console.ReadLine(); //gets input and apply it to the variable userText

            //---------------------------------------------------------------------------------------------------------------------------------
            //------------------------loop using the "less than (<) operator-------------------------------------------------------------------
            //---------------------------------------------------------------------------------------------------------------------------------

            for (int i = 0; i < fruits.Length; i++) //for loop will iterate through the string array once for each index
            {
                fruits[i] += userText; //append the users text the each iteration of string array fruits
            }

            //----------------------------------------------------------------------------------------------------------------------------------
            //-----------------------loop using the "less than or equal to" (<=) operator-------------------------------------------------------
            //----------------------------------------------------------------------------------------------------------------------------------

            Console.WriteLine("\nModified array:"); //skips a line then writes to console a new header
            for (int i = 0; i <= fruits.Length - 1; i++) //for loop will iterate through the string array once for each index
            {
                Console.WriteLine(fruits[i]); //writes to console the modified array
            }

            //------------------------------------------------------------------------------------------------------------------------------------
            //--------------------------loop that searches for matching text----------------------------------------------------------------------
            //------------------------------------------------------------------------------------------------------------------------------------

            List<string> textList = new List<string> { "Red", "flower", "bird", "123", "mother" }; //create a string type list with unique items
            bool matchFound = false; //define a boolean variable to use as logic for a match
            while (!matchFound) //start a while loop that will continue until matchFound is changed to true
            {
                Console.WriteLine("\nPlease input some text to search for in this list:"); //skips a line then prompts the user to input some text
                string userResponse = Console.ReadLine(); //gets input and applys it to the variable userResponse
                for (int i = 0; i < textList.Count; i++) //for loop will iterate through the string list once for each index
                {
                    if (textList[i] == userResponse) //branching statement to test for match
                    {
                        Console.WriteLine("This matches the item with the index of: " + i); //writes to the console that a match has been made and
                                                                                            //the index number
                        matchFound = true; //changes the boolean variable to true so the loop will terminate
                    }
                }
                if (!matchFound) //branching statement to test for not a match
                {
                    Console.WriteLine("This is not in the list. Please try again."); //writes to the console that this is not a match and to
                                                                                     //try again
                }
            }

            //--------------------------------------------------------------------------------------------------------------------------------------
            //--------------------------------loop that is capable of finding more than on match before it terminates-------------------------------
            //--------------------------------------------------------------------------------------------------------------------------------------

            List<string> nextTextList = new List<string> { "Red", "flower", "bird", "123", "mother", "bird" }; //create a string type list with at
                                                                                                               //least two identical strings
            Console.WriteLine("\nPlease input some new text for the next search in another list:"); //skips a line then prompts the user to input
                                                                                                    //some text
            string userInput = Console.ReadLine(); //gets input and applys it to the variable userInput
            List<int> matchingIndices = new List<int>(); //define a list to store indices of matching items in nextTextList
            for (int i = 0; i < nextTextList.Count; i++) //for loop will iterate through the string list once for each index
            {
                if (nextTextList[i] == userInput) //branching statement to test for match
                {
                    matchingIndices.Add(i); //adds the index of the matching item to matchingIndices
                }
            }

            if (matchingIndices.Count > 0) //branching statement to check for any matches
            {
                foreach (int index in matchingIndices) //for loop will iterate through the string list once for each index
                {
                    Console.WriteLine("This matches the item with the index of: " + index); //writes to the console that a match has been made and
                                                                                            //the index number
                }
            }
            else //branching statement for no matches
            {
                Console.WriteLine("There is no match in the list."); //writes to console there are no matches
            }

            //-----------------------------------------------------------------------------------------------------------------------------------------
            //--------------------------------------loop that evauates each item in the list-----------------------------------------------------------
            //-----------------------------------------------------------------------------------------------------------------------------------------

            List<string> thirdTextList = new List<string> { "1", "2", "3", "4", "5", "2" }; //create a string type list with at
                                                                                            //least two identical strings
            HashSet<string> uniqueSet = new HashSet<string>(); //HashSet to store unique values
            Console.WriteLine(); //skip a line
            Console.WriteLine("Evaluation of thirdTextList\n");
            foreach (string value in thirdTextList) //foreach loop to iterate through each index in thirdTextList
            {
                if (uniqueSet.Contains(value)) //branching statement to check for duplicates
                {
                    Console.WriteLine($"{value} - this item is a duplicate."); //writes to console that the item is a duplicate using interpolation
                }
                else //branching statement for unique values
                {
                    uniqueSet.Add(value); //adds value to uniqueSet
                    Console.WriteLine($"{value} - this item is unique."); //writes to console that this item is unique using interpolation
                }
            }
         
            Console.WriteLine("\nTo enter the infinite loop, press enter."); //write to console instruction for entering the infinite loop.
            Console.ReadKey(); //holds console open

            //-----------------------------------------------------------------------------------------------------------------------------------------
            //--------------------------------------- Infinite loop added------------------------------------------------------------------------------
            //-----------------------------------------------------------------------------------------------------------------------------------------
            while (true) //the infinate loop starts here and will only stop when the program is manually terminated
            {
            }
            //-----------------------------------------------------------------------------------------------------------------------------------------
            //------------------------------------------end of infinite loop---------------------------------------------------------------------------
            //-----------------------------------------------------------------------------------------------------------------------------------------
        }
    }
}

