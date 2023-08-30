function abc() {  //This function declares and assigns values to several variable.
    var A = "a ";
    var B = "b ";
    var C = "c ";
    var D = "d ";
    var E = "e ";
    var F = "f ";
    var G = "g";
    var complete = A.concat(B, C, D, E, F, G);  //This variable is where all the other variables get concatenated together.
    document.getElementById("alphabit").innerHTML = complete + " - These letters were concatenated together.";  //Prints to the document.
}
function slice() {  //This function slices out the characters indexed at 4 to 6 in the variable "example".
    var example = "How is it going?";
    var res = example.slice(4, 6);  //gets sliced right here.
    document.getElementById("here").innerHTML = 'The characters "' + res + '" have been sliced from the phrase,"How is it going?"';  //Prints to the document.
}
function upper_case() {  //This function changes the string variable to all upper case.
    var X = "hey there!";
    var Z = X.toUpperCase();  //Upper case happens right here.
    document.getElementById("there").innerHTML = Z + " Has been changed to all caps.";  //Prints to the document.
}
function X() {  //This function give the index of the word "Jill" in the string variable "text".
    var text = "Jack and Jill went up the hill.";
    var index = text.indexOf("Jill");  //Gets indexed right here.
    document.getElementById("where").innerHTML = 'Jill has an index of ' + index + ' in the sentence above.';  //Prints to the document.
}
function N_S() {  //This function changes a number to a "string".
    var P = 954;
    document.getElementById("over_here").innerHTML = 'The number 954 has been changed to the string "' + P.toString() + '".';  //Prints to the document and gets changed to a string right here.
}
function toP() {  //This function rounds up a number to the parameters inputted.
    var J = 1234.5678901234567890;
    document.getElementById("this_spot").innerHTML = 'The number 1234.5678901234567890 has been adjusted to a length os 6 digits, ' + J.toPrecision(6);  //Prints to the document and formats the number to the specified length according to the parameters.
}
function toF() {  //This function rounds up a number to the specified parameters.
    var num = 4.58902;
    var n = num.toFixed(2);  //Gets rounded up here.
    document.getElementById("over_there").innerHTML = "4.58902 rounded up to two digits past the decimal point is: " + n;  //Prints to the document.
}
function vOf() {  //This funcion returns the value of a string.
    var T = "Here's Jonny!";
    var S = T.valueOf();  //returns the value here.
    document.getElementById("spot").innerHTML = 'The variable "T" has a value of "' + S + '"';  //Prints to the document.
}