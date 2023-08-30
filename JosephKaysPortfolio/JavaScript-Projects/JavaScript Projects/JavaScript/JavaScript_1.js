function foodFunction() {
    var theStatement;
    var favorite = document.getElementById("favFood").value;
    var addOn = " is a delicious food!";
    switch(favorite) {
        case "cheeseburger":
            theStatement = "cheeseburger" + addOn;
        break;
        case "pizza":
            theStatement = "pizza" + addOn;
        break;
        case "hot dog":
            theStatement = "hot dog" + addOn;
        break;
        case "grilled cheese sandwich":
            theStatement = "grilled cheeese sandwich" + addOn;
        break;
        case "taco":
            theStatement = "taco" + addOn;
        break;
        case "gyro":
            theStatement = "gyro" + addOn;
        break;
        default:
        theStatement = "Please enter a food exactly as it is written in the above list.";
    }
    document.getElementById("statement").innerHTML = theStatement;
}

function Text_Change_Function() {
    var sentence = document.getElementsByClassName("text");
    sentence[0].innerHTML = "The text has changed!";
    sentence[2].innerHTML = "The text changed also!";
}

const ck = document.getElementById("myCanvas");
const ckmk = ck.getContext("2d");
ckmk.beginPath();
ckmk.moveTo(165,140);
ckmk.bezierCurveTo(80,200,100,350,500,90);
ckmk.fill();
const cut = document.getElementById("myCanvas");
const cutout = cut.getContext("2d");
cutout.beginPath();
cutout.moveTo(170,130);
cutout.bezierCurveTo(170,140,70,280,530,80);
cutout.fillStyle = "white";
cutout.fill();

const canvas2 = document.getElementById("myCanvas2");
const backFill = canvas2.getContext("2d");
const gradient = backFill.createLinearGradient(0,0,600,0);
gradient.addColorStop(0, "blue");
gradient.addColorStop(1, "white");
backFill.fillStyle = gradient;
backFill.fillRect(0,0,600,300);