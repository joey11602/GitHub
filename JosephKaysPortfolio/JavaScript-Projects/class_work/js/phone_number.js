function validateForm() {
    let C = document.forms["aForm"]["phoneNumber"].value;
    if (C == "") {
        alert("Please fill out your phone number");
        return false;
    }
}

function openForm() {
    document.getElementById('myForm').style.display = "block";
}

function closeForm() {
    document.getElementById('myForm').style.display = "none";
}