//********ternary operation*************/
function V_Function() {  //declares a function
    var age, ofAge;  //declares a variable
    age = document.getElementById("Age").value;  //retrieves the value from the HTML document
    ofAge = (age > 17)? "You are old enough to vote":"You are not old enough to vote";  //calulates the val ofAge
    document.getElementById("vote").innerHTML = ofAge + " today.";  //places the calculated statement in the HTML document
}
//************class and constructor function**************/
function Dog(Breed, Color, Sex) {  //this function creates the class and three constructors
    this.Dog_Breed = Breed;
    this.Dog_Color = Color;
    this.Dog_Sex = Sex;
}
//**************declaring new variable instances of the class Dog with it's constructors***************/
var Don = new Dog("German Shepard", "brown and black", "male");
var Fred = new Dog("Chihuahua", "white and black", "female");
var Jan = new Dog("Labrador", "black", "male");
//*************parsing the class and constructors to print the desired information in the HTML document*****/
function GetInfo() {
    document.getElementById("Info").innerHTML =
   "Don has a " + Don.Dog_Color + "-colored " + Don.Dog_Sex + " " + Don.Dog_Breed + ".";
}
//******************nested function********************************************************/
function OuterFunction() {  //outer function code block
    function InnerFunction() {  //inner function code block
        var A = "Hello";  //declare a variable and give it a value
        document.getElementById("Nested_Function").innerHTML = A;  //print the result of the inner function to the HTML document
    }
    InnerFunction();  //call the inner function
}