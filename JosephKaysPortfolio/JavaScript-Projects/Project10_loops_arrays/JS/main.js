//while loop
function increment() {  //this function uses a while loop to count to 15
    const num = [];  //declares a constant that is an array
    var x = 1;  //declares a variable and gives it my starting count value
    var z = 0;  //declares a variable and gives it the starting index for the array
    while (x < 16) {  //this is my while loop condition 
        num[z] = x + " ";  //this will build my array to hold 15 numbers
        z++;  //increments the index
        x++;  //increments the count 
        }
    document.getElementById("value").innerHTML = num;  //prints to the document my count
}
//for loop
var tools = ["hammer", "screwdriver", "tape measure", "t-square", "utility knife", "pliers", "hand saw"];  //declares a variable and gives it a value to make an array
var toolBox = "";  //declares a variable for the secondary array
var count;  //declares a variable that will be used to compare the index number to the length property in the for loop
function forLoop() {  // this function uses the for loop to count number of values so that I can print them out on a seperate line
    for (count = 0; count < tools.length; count++) {  //this is the for loop, a start value is given to the variable "count", the condotion for it and an increment for the variable
        toolBox += tools[count] + "<br>";  //this fills in the secondary array, each value on a seperate line
    }
    document.getElementById("list_of_tools").innerHTML = toolBox;  //prints to the document
}
//array
function arrayFunction() {  //this function makes an array and prints a sentence from parts of the arrays string values
    var myLunch = [];  //delares a variable as an array
    myLunch[0] = "ham sandwhich";  //the following lines fill the array with values-^
    myLunch[1] = "bag of chips";  //------------------------------------------------^
    myLunch[2] = "apple";  //-------------------------------------------------------^
    myLunch[3] = "slice of cherry pie";  //-----------------------------------------^
    myLunch[4] = "bottle of water";  //---------------------------------------------^
    document.getElementById("array").innerHTML = "I had an " + myLunch[2] + " with my lunch.";  //creates and prints a sentence from the string information in the array
}

/*this wasn't used in my submission
//constant
function constantFunction() {
    const pickupTruck = {make:"Ford", model:"2023", color:"black"};
    pickupTruck.make = "GMC";
    pickupTruck.color = "blue";
    document.getElementById("constant").innerHTML = "I have a " + pickupTruck.color + " " 
    + pickupTruck.model + " " + pickupTruck.make + " pick up truck.";
}*/
//create an object using a let type variable
function objectFunction() {  //this function creates an object using the let keyword
    let pet = {type:"dog", name:"Fido", color:"white with black spots", age:3};  //declares a variable and fills in the object type information
    document.getElementById("object").innerHTML = pet.name + " the " + pet.type + " is " + pet.color + ".";  //creates and prints a sentence using the objects and properties
}