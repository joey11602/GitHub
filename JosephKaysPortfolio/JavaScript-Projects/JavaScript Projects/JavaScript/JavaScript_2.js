function validateForm() {
    let F = document.forms["myForm"]["Fname"].value;
    if (F == "") {
        alert("First name must be filled out");
        return false;
    }
    let L = document.forms["myForm"]["Lname"].value;
    if (L == "") {
        alert("Last name must be filled out");
        return false;
    }
    let E = document.forms["myForm"]["EM"].value;
    if (E == "") {
        alert("Your email address must be filled out");
        return false;
    }
  }