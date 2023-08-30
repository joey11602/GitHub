function TypeOf() {  //declares a function
    var A = "alpha"  //declares a variable and assigns a value
    document.getElementById("alpha").innerHTML = '"alpha" is the variable type: '+(typeof A);  //displays the type of variable in the document
}
function combineTwo() {  //declares a function
    document.getElementById("combine").innerHTML = "adding a string and a number together: "+("Jonny" + 5);  //displays the two type of variable added together in the document
}
function F() {  //declares a function
    document.getElementById("f").innerHTML = "15 = 10? "+(15==10);  //displays the boolean logic comparing equlity in the document
}
function TT() {  //declares a function
    document.getElementById("tt").innerHTML = "10 = 10 and is the same type? "+(10===10);  //displays the boolean logic comparing equlity and type in the document
}
function LessThan() {  //declares a function
    document.getElementById("lessthan").innerHTML = "20 < 10? "+(20<10);  //displays the boolean logic using the "Less Than" operator in the document
}
function GreaterThan() {  //declares a function
    document.getElementById("greaterthan").innerHTML = "20 > 10? "+(20>10);  //displays the boolean logic using the "Greater Than" operator in the document
}
function And() {  //declares a function
    document.getElementById("and").innerHTML = "2 > 1 and 4 > 2? "+(2>1 && 4>2);  //displays the boolean logic using the "AND" operator in the document
}
function Or() {  //declares a function
    document.getElementById("or").innerHTML = "2 > 1 or 4 < 2? "+(2>1 || 4<2);  //displays the boolean logic using the "OR" operator in the document
}
function not_Function() {  //declares a function
    document.getElementById("Not").innerHTML = "Not 30 > 20? "+!(30 > 20);  //displays the boolean logic using the "NOT" operator in the document
}