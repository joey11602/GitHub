var A = 20;  //Global Variable
function divide_function() {  //Division Function 
    B = (A / 2);  
    document.getElementById("global").innerHTML = B;  //Prints to document @ "global".
}
function multiply_function () {  //Multiplication Function/I used the same variables here to show that local variables are only accessible inside its function.
    var A = 2;  //Local Variable
    B = (A * 10);  
    document.getElementById("local").innerHTML = B;  //Prints to document @ "local".
}
function error_function() {  //This function has an error in it so I could debug it in the chrome console.
    var X = 10;
    document.getElementById("error").innerHTML = this_is_my_error;  //"this_is_my_error" is the error, it is a undefined variable.
}
function CompareFunction() {  //This function compares the inputted value to see if it is a match.
    let color1 = document.getElementById("color").value;  //Assigns the inputted value the variable "color1".
    let LCcolor = color1.toLowerCase();  //Changes the string into all lowercase letters.
    if (LCcolor == "purple") {  //This is the if statement that compares the inputted color to purple.
        answer = "That's my favorite color!";  //If the argument is true, this is the string that is assigned to the variable "answer".
    }
    else {
        answer = "That's a nice color, but my favorite color is purple.";  //If the argument is false, this is the string that is assigned to the variable "answer".  
    }
    document.getElementById("MyFavColor").innerHTML = answer;  //Prints to document @ "MyFavColor".
}
function Time_function() {  //This is the time function i was required to type out.
    var Time = new Date().getHours();
    var Reply;
    if (Time < 12 == Time > 0) {  //<<<<<<<<I don't understand this logic here. But if this statement is true, then Reply = "It is morning time!".
        Reply = "It is morning time!";
    }
    else if (Time >= 12 == Time < 18) {  //<<<<<<<<<<<<<<I don't understand this logic here. But if the first statement was false, and this statement is true, then  Reply = "It is afternoon.".
        Reply = "It is afternoon.";
    }
    else {  //If both the first and second statements are false, and this statement is true, then Reply = "It is evening time."
        Reply = "It is evening time.";  
    }
    document.getElementById("Time_of_day").innerHTML = Reply;  //Prints to document @ "Time_of_day".
}
