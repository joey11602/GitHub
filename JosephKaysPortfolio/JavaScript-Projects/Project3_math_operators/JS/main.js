function myFunction() {  //declares a function
    var add = 2 + 2;
    document.getElementById("Math").innerHTML="2 + 2 = " + add;  //shows the result of the argument in the document
}
function SubtractionFunction() {  //declares a function
    var subtract = 4 - 2;
    document.getElementById("Subtraction").innerHTML="4 - 2 = " + subtract;  //shows the result of the argument in the document
}
function MultiplicationFunction() {  //declares a function
    var multiply = 2 * 2;
    document.getElementById("Multiply").innerHTML="2 * 2 = " + multiply;  //shows the result of the argument in the document
}
function DivisionFunction() {  //declares a function
    var divide = 4 / 2;
    document.getElementById("Divide").innerHTML="4 / 2 = " + divide;  //shows the result of the argument in the document
}
function MultiMathFunction() {  //declares a function
    var multimath = (2 + 2 - 2) / 2 * 15;
    document.getElementById("MultiMath").innerHTML="(2 + 2 - 2) / 2 * 15 = " + multimath;  //shows the result of the argument in the document
}
function RemainderFunction() {  //declares a function
    var remainder = 24 % 7;
    document.getElementById("Remainder").innerHTML="24 / 7 has a remainder of " + remainder;  //shows the result of the argument in the document
}
function NegativeFunction() {  //declares a function
    var negative = 20;
    document.getElementById("Negative").innerHTML= -negative;  //shows the result of the argument in the document
}
function IncrementFunction() {  //declares a function
    var increment = 10;
    increment++;
    document.getElementById("Increment").innerHTML= "10 that has been incremented is " + increment;  //shows the result of the argument in the document
}
function DecrementFunction() {  //declares a function
    var decrement = 30;
    decrement--;
    document.getElementById("Decrement").innerHTML= "30 that has been decremented is " + decrement;  //shows the result of the argument in the document
}
function RandomFunction() {  //declares a function
    var random = Math.floor(Math.random() * 50);
    document.getElementById("Random").innerHTML= "This is a random number between 1 and 50 that has been generated by my function " + random;  //shows the result of the argument in the document
}
function PiFunction() {  //declares a function
    var pi = Math.PI
    document.getElementById("Pi").innerHTML= "This is the number for PI " + pi;  //shows the result of the argument in the document
}
