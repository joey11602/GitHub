//slideshow starting point
let slideIndex = 1;
showSlides(slideIndex);

//backward and forward buttons
function plusSlide(n) {
    showSlides(slideIndex += n);
}

//index dot buttons
function currentSlide(n) {
    showSlides(slideIndex = n);
}

//main function
function showSlides(n) {
    let i;
    let slides = document.getElementsByClassName("mySlides");
    let dots = document.getElementsByClassName("dot");
    if (n > slides.length) {slideIndex = 1}
    if (n < 1) {slideIndex = slides.length}
    for (i = 0; i < slides.length; i++) {
        slides[i].style.display = "none";
    }
    for (i = 0; i < dots.length; i++) {
        dots[i].className = dots[i].className.replace(" active", '');
    }
    slides[slideIndex-1].style.display = "block";
    dots[slideIndex-1].className += " active";
}

//countdown function
function countdown() {
    var seconds = document.getElementById("seconds").value;  //get number of seconds that are to be counted down

    function tick() {
        seconds = seconds - 1;  //subtracts 1 from seconds for every time the function is called
        timer.innerHTML = seconds;  //displays the value of "seconds" each time the function is called
        var time = setTimeout(tick, 1000); //calls function "tick" every 1000 milliseconds
        if (seconds == -1) {  //conditional statement, if true, the following code blocks are executed
            alert("Time's up!");  //pop up window in the browser displays "Time's up!"
            clearTimeout(time);  //clears the Timeout timer
            timer.innerHTML = "";  
        }
    }
    tick();
}