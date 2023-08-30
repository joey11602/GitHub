function the_function() {  //declares the function and names it
    var the_first_one = "This is my first variable.",  //declares the first variable and gives it a string value
        the_second_one = "This is my second variable.";  //declares the second variable and gives it a string value  
    document.getElementById("button_change").innerHTML = the_first_one + " " + the_second_one;  //replaces the text with the value of the variable "change" right after the id="button_change"
}
var color1 = document.getElementById("color1");  //declares a variable and sets the id
color1.addEventListener("mouseover", function handleMouseOver() {
    color1.style.color = "red"; //sets up EventListener on id"color1" for mouseover and changes text color to red
});
color1.addEventListener("mouseout", function handleMouseOut() {
    color1.style.color = "black";  //sets up EventListener for mouseout and changes text color back to black
});
function the_other_function() {  //declares the function and names it
    var A = "This is kind of tricky to figure out.";  //declares the first variable and gives it a string value
    var B = "It's a good thing I have great instructors!";  //declares the second variable and gives it a string value 
    A += " ";  //concatenates variable "A" and " "
    A += B;  //concatenates variable "A" and variable "B"
    document.getElementById("goes_right_here").innerHTML = A;  //replaces text onclick with variable "A" 
}