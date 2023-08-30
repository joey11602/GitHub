function dictionary1 () {  //declares a function
    var Student = {  //declares a variable and sets up a KVP
        LastName: "Kay",
        FirstName: "Joseph",
        Gender: "Male",
        Age: "55",
        Location: "Alabama"
    };
    document.getElementById("Dictionary1").innerHTML = "Student's location: "+Student.Location;  //displays the KVP in the document
}
function dictionary2 () {  //declares a function
    var Student = {  //declares a variable and sets up a KVP
        LastName: "Kay",
        FirstName: "Joseph",
        Gender: "Male",
        Age: "55",
        Age: "65",
        Location: "Alabama"
    };
    document.getElementById("Dictionary2").innerHTML = "Student's age: "+Student.Age;  //displays the KVP in the document
}
function dictionary3 () {  //declares a function
    var Student = {  //declares a variable and sets up a KVP
        LastName: "Kay",
        FirstName: "Joseph",
        Gender: "Male",
        Age: "55",
        Age: "65",
        Location: "Alabama"
    };
    delete Student.LastName  //deletes a KVP
    document.getElementById("Dictionary3").innerHTML = "Student's last name: "+Student.LastName;  //displays the KVP in the document
}