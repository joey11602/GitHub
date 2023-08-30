window.alert("Hello, World!");  //prints the text in the alert window of my html page
document.write('Hello, World!');  //prints the text to the document in my html page
var A = "What's up!";  //declares a variable and assigns a string value to it
document.write(A);  //prints variable "A" to the document on my html page
var B = "My name is Joey.";  //declares a variable and asigns a string value to it
window.alert(B);  //prints variable "B" in the alert window of my html page
document.write('That is Joey\'s computer.');  //demonstrates how to use an escape character
document.write("Jack and Fred" + " went for a walk.");  //concatenates two strings together and prints them on the document on my html page
var C = "Rose and" + " Mary are good friends.";  //declares a variable and assigns the two variables concatenated together
document.write(C);  //prints variable "C" to the document on my html page   
var color = "blue", dog = "labador", year = "2023";  //declares three variables and assigns three seperate values to them on one line of code
document.write(color);  //prints variable "color" to the document on my html page
document.write(6 / 2 + 3);  //prints the result of this expression to the document on my html page
function My_First_Function() {  //declares the function and names it
    var str = "This is the button text!";  //declares a variable and gives it a string value
    document.getElementById("Button_Text").innerHTML = str  //replaces the text with the value of the variable "str" right after the id="Button_Text"                                                           
};