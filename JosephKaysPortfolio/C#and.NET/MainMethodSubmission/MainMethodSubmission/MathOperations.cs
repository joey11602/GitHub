namespace MainMethodSubmission
{
    class MathOperations //create a class called Mathoperations
    {
        public int PerformMathOperation(int number) //method for integer parameter
        {
            int result = number + 5; //add 5 to the parameter number
            return result; //return result to main program
        }

        public int PerformMathOperation(decimal decimalNumber) //method for decimal parameter
        {
            int result = (int)(decimalNumber * 2); //multiply the parameter decimalNumber by 2 and convert the answer to an integer
            return result; //return result to main program
        }

        public int PerformMathOperation(string strNumber) //method for string parameter
        {
            int parsedNumber; //define variable parsedNumber
            if (int.TryParse(strNumber, out parsedNumber)) ; //use TryParse to convert string to integer
            else //if TryParse fails use 0
            {
                parsedNumber = 0;
            }
            int result = parsedNumber * parsedNumber; //square the parameter strNumber
            return result; //return result to main program
        }
    }
}
