function getReceipt() {//this function is called when the place order button is clicked and it starts the process that figures the cost
    var text1 = "<h3>You Ordered:</h3>";//this is set up for the check out, it's the first part of the string to be displayed to the html
    var runningTotal = 0;//this declares the variable for tracking the total through out the order
    var sizeTotal = 0;//this declares the variable for the charge for the size pizza that is selected
    var sizeArray = document.getElementsByClassName("size");//this gets the size that is ordered from the html
    for (var i = 0; i < sizeArray.length; i++) {//this is the loop that cycles through all the size inputs from the html
        if (sizeArray[i].checked) {//this conditional statement determines which size is checked
            var selectedSize = sizeArray[i].value;//this variable gets declared and is assigned the indexed value of the sizeArray
            text1 = text1+selectedSize+"<br>"; //this is where "text1" is concatenated together with the selected size
        }
}
//this logic determines the price and gives that value to "sizeTotal"
if (selectedSize === "Personal Pizza") {
    sizeTotal = 6;
} else if (selectedSize === "Small Pizza") {
    sizeTotal = 8;
} else if (selectedSize === "Medium Pizza") {
    sizeTotal = 10;
} else if (selectedSize === "Large Pizza") {
    sizeTotal = 14;
} else if (selectedSize === "Extra Large Pizza") {
    sizeTotal = 16;
}
runningTotal = sizeTotal;//this updates the runningTotal with the correct cost of the size chosen
//--------------------------------------------------------------------------------------------------------------------------------------------
console.log(selectedSize+' = $'+sizeTotal+'.00');//-------------------------------------------------------------------------------------------
console.log('size text1: '+text1);//---------------I'm not sure exactly what this is for. I removed it and it worked fine. Perhaps it's for---
console.log("subtotal: $"+runningTotal+".00");//---troubleshooting the web page. It shows a breakdown of the charges in the console.----------
//-------------------------------------------------------------------------------------------------------------------------------------------- 
getTopping(runningTotal, text1);//this calls a function and provides parameters
};
function getTopping (runningTotal, text1) {
    var toppingTotal = 0;//declares a variable for the number of toppings selected
    var selectedTopping = [];//declares a variable for an array to staore the different toppings selected
    var toppingArray = document.getElementsByClassName("toppings");//this declares a variable to cycle through the topping inputs from the html
    for (var j = 0; j < toppingArray.length; j++) {//this for loop cycles through the topping inputs
        if (toppingArray[j].checked) {//this conditional statement checks to see if the topping is selected
            selectedTopping.push(toppingArray[j].value);//this inserts the selected topping from the "toppingArray" array to the "selectedTopping" array
            //---------------------------------------------------------------------------------------------------------------------------------
            console.log("selected topping item: ("+toppingArray[j].value+")");//same as above, not necessary to function-----------------------
            //---------------------------------------------------------------------------------------------------------------------------------
            text1 = text1+toppingArray[j].value+'<br>';//this concatenates the toppings selected from the "toppingArray" to the last value of text1
        }
    }
    var toppingCount = selectedTopping.length;//this variable is delared and assigned the value of the toppings selected by the .length method
    if (toppingCount > 1) {//this conditional statement is set up so that it will give you one free topping
        toppingTotal = (toppingCount - 1);
    } else {
        toppingTotal = 0;
    }
    runningTotal = (runningTotal + toppingTotal);//this adds up the size charge and the topping charge
    //----------------------------------------------------------------------------------------------------------------------------------------
    console.log("total selected topping items: "+toppingCount);//same as above, not necessary to function-------------------------------------
    console.log(toppingCount+" topping - 1 free topping = "+"$"+toppingTotal+".00");//--------------------------------------------------------
    console.log("topping text1: "+text1);//---------------------------------------------------------------------------------------------------
    console.log("Purchase Total: "+"$"+runningTotal+".00");//---------------------------------------------------------------------------------
    //----------------------------------------------------------------------------------------------------------------------------------------
    document.getElementById("showText").innerHTML=text1;//this prints the concatenated "text1" to the html showing you what you ordered
    document.getElementById("totalPrice").innerHTML = "<h3>Total: <strong>$"+runningTotal+".00"+"</strong></h3>";//this prints the total price
}