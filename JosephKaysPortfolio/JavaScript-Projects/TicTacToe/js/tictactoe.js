//this variable tracks whose turn it is.
let activePlayer = 'X';
//this stores all the moves.
let selectedSquares = [];

//this function is for placing a google or a twitter in the box.
function placeXOrO(squareNumber) {
    //this makes sure a square hasn't been selected.
    //the .some() method is used to check each element of the selectSquare array
    //to see if it has been clicked on.
    if (!selectedSquares.some(element => element.includes(squareNumber))) {
        //this variable retrieves the HTML element id that was clicked.
        let select = document.getElementById(squareNumber);
        //this condition checks to see who's turn it is.
        if (activePlayer === 'X') {
            //if activePlayer is equal to 'X', the twitter is placed in HTML
            select.style.backgroundImage = 'url("images/twitter.png")';
            //active player can only be 'X' or 'O'
        } else {
            //if activePlayer is equal to 'O', the google is placed in HTML
            select.style.backgroundImage = 'url("images/google.png")';
        }
        //squareNumber and activePlayer are concatenated together and added to array.
        selectedSquares.push(squareNumber + activePlayer);
        //this calls a function to check for a win condition.
        checkWinConditions();
        //this is for changing the active player.
        if (activePlayer === 'X') {
            //if active player is 'X' change it to 'O'.
            activePlayer = 'O';
            //if active player is anything other than 'X'
        } else {
            //change the activePlayer to 'X'
            activePlayer = 'X';
        }
        //this function plays a mp3 file for when a space is selected.
        audio('./media/slide.mp3');
        //this condition checks to see if it is the computers turn.
        if (activePlayer === 'O') {
            //disables clicking for computers turn.
            disableClick();
            //time delay
            setTimeout(function () { computersTurn(); }, 1000);
        }
        //true is needed for our computersTurn() function to work.
        return true;
    }
    //this randomly picks a square for the coputers turn.
    function computersTurn() {
        //this boolean is needed for our while loop.
        let success = false;
        //this variable stores a random number 0-8.
        let pickASquare;
        //this condition lets our while loop keep trying if a square is selected already.
        while (!success) {
            //random number between 0 and 8 is selected.
            pickASquare = String(Math.floor(Math.random() * 9));
            //if the random number chosen returns true, the square hasn't been selected yet.
            if (placeXOrO(pickASquare)) {
                //this line calls the function.
                placeXOrO(pickASquare);
                //this changes our boolean and ends the loop.
                success = true;
            };
        }
    }
}

//this function checks the selectedSquares array to see if there is a win condition.
//drawLine() function is called to draw a line on the three in a row.
function checkWinConditions() {
    //X 0, 1, 2 condition.
    if (arrayIncludes('0X', '1X', '2X')) { drawWinLine(50, 100, 558, 100) }
    // X 3, 4, 5 condition.
    else if (arrayIncludes('3X', '4X', '5X')) { drawWinLine(50, 304, 558, 304) }
    //X 6, 7, 8 condition.
    else if (arrayIncludes('6X', '7X', '8X')) { drawWinLine(50, 508, 558, 508) } 
    //X 0, 3, 6 condition.
    else if (arrayIncludes('0X', '3X', '6X')) { drawWinLine(100, 50, 100, 558) }
    //X 1, 4, 7 condition.
    else if (arrayIncludes('1X', '4X', '7X')) { drawWinLine(304, 50, 304, 558) }
    //X 2, 5, 8 condition.
    else if (arrayIncludes('2X', '5X', '8X')) { drawWinLine(508, 50, 508, 558) }
    //X 6, 4, 2 condition.
    else if (arrayIncludes('6X', '4X', '2X')) { drawWinLine(100, 508, 510, 90) }
    //X 0, 4, 8 condition.
    else if (arrayIncludes('0X', '4X', '8X')) { drawWinLine(100, 100, 520, 520) }
    //O 0, 1, 2 condition.
    else if (arrayIncludes('0O', '1O', '2O')) { drawWinLine(50, 100, 558, 100) }
    //O 3, 4, 5 condition.
    else if (arrayIncludes('3O', '4O', '5O')) { drawWinLine(50, 304, 558, 304) }
    //O 6, 7, 8 condition.
    else if (arrayIncludes('6O', '7O', '8O')) { drawWinLine(50, 508, 558, 508) }
    //O 0, 3, 6 condition.
    else if (arrayIncludes('0O', '3O', '6O')) { drawWinLine(100, 50, 100, 558) }
    //O 1, 4, 7 condition.
    else if (arrayIncludes('1O', '4O', '7O')) { drawWinLine(304, 50, 304, 558) }
    //O 2, 5, 8 condition.
    else if (arrayIncludes('2O', '5O', '8O')) { drawWinLine(508, 50, 508, 558) }
    //O 6, 4, 2 condition.
    else if (arrayIncludes('6O', '4O', '2O')) { drawWinLine(100, 508, 510, 90) }
    //O 0, 4, 8 condition.
    else if (arrayIncludes('0O', '4O', '8O')) { drawWinLine(100, 100, 520, 520) }
    //this checks for a tie. if there are no win conditions and 9 boxes are picked
    //it is a tie and the else if statement executes.
    else if (selectedSquares.length >= 9) {
        //this function plays the boing sound for a tie.
        audio('./media/boing.mp3');
        //time delay before reset.
        setTimeout(function () { resetGame(); }, 500);
    }
    //this function checks if an array includes 3 strings. it is used to check for
    //each win condition.
    function arrayIncludes(squareA, squareB, squareC) {
        //these 3 variables will be used to check for 3 in a row.
        const a = selectedSquares.includes(squareA);
        const b = selectedSquares.includes(squareB);
        const c = selectedSquares.includes(squareC);
        //if the 3 variables we pass are all included in our array then
        //true is returned and our else if condition executes the drawLine() function.
        if (a === true && b === true && c === true) { return true; }
    }
} 

//this disables the click in the body section of the html.
function disableClick() {
    //this makes our body unclickable.
    body.style.pointerEvents = 'none';
    //i second time delay before we can click again.
    setTimeout(function () { body.style.pointerEvents = 'auto'; }, 1000);
}

//this function takes a string parameter of the path you set earlier for
//placement sound('./media/place.mp3')
function audio(audioURL) {
    //we create a new audio object and we pass the path as a parameter.
    let audio = new Audio(audioURL);
    //play method plays our audio sound.
    audio.play();
}

//this function utilizes HTML canvas to draw lines.
function drawWinLine(coordX1, coordY1, coordX2, coordY2) {
    //this line accesses our HTML canvas element.
    const canvas = document.getElementById('win-lines');
    //this line gives us access to methods and properties to use on canvas.
    const c = canvas.getContext('2d');
    //this line indicates where the start of a line x axis is.
    let x1 = coordX1,
    //this line indicates where the start of a line y axis is.
        y1 = coordY1,
        //this line indicates where the end of line x axis is.
        x2 = coordX2,
        //this line indicates where the end of line y axis is.
        y2 = coordY2,
        //this variable stores temporary x axis data we update in our animation loop.
        x = x1,
        //this variable stores temporary y axis data we update in our animation loop.
        y = y1;
    //this function interacts with the canvas.
    function animateLineDrawing() {
        //this variable creates a loop'
        const animationLoop = requestAnimationFrame(animateLineDrawing);
        //this method clears content from the last loop iteration.
        c.clearRect(0, 0, 608, 608);
        //this method start a new path.
        c.beginPath();
        //this method moves us to a starting point in our line.
        c.moveTo(x1, y1);
        //this method indicates the end point in our line.
        c.lineTo(x, y);
        //this method sets the width of our line.
        c.lineWidth = 10;
        //this method sets the color of our line.
        c.strokeStyle = 'rgba(70, 255, 33, .8)';
        //this method draws everything we laid out above.
        c.stroke();
        //this condition checks if we've reached the endpoint.
        if (x1 <= x2 && y1 <= y2) {
            //this condition adds 10 to the previous end x endpoint.
            if (x < x2) { x += 10; }
            //this condition adds 10 to the previous end y endpoint.
            if (y < y2) { y += 10; }
            //this condition is similar to the one above.
            //this is necessary for the 6, 4, 2 win conditions.
            if (x >= x2 && y >= y2) { cancelAnimationFrame(animationLoop); }
        }
        //this condition is similar to the one above.
        //this is necessary for the 6, 4, 2 win condition.
        if (x1 <= x2 && y1 >= y2) {
            if (x < x2) { x += 10; }
            if (y > y2) { y -= 10; }
            if (x >= x2 && y <= y2) { cancelAnimationFrame(animationLoop); }
        }
    }
    //this function clears our canvas after our win line is drawn.
    function clear() {
        //this line starts our animation loop.
        const animationLoop = requestAnimationFrame(clear);
        //this line clears our canvas.
        c.clearRect(0, 0, 608, 608);
        //this line stops our animation loop.
        cancelAnimationFrame(animationLoop);
    }
    //this line disallows clicking while the bell sound is playing
    disableClick();
    //this line plays the bell sounds.
    audio('./media/bell.mp3');
    //this line calls our main animation loop.
    animateLineDrawing();
    //1 second time delay then reset.
    setTimeout(function () { clear(); resetGame(); }, 1000);
}

//resets the game if there is a tie or win.
function resetGame() {
    //this for loop iterates through each HTML square element.
    for (let i = 0; i < 9; i++) {
        //this variable gets the HTML element i.
        let square = document.getElementById(String(i));
        //this removes our elements backgroundImage.
        square.style.backgroundImage = '';
    }
    //this resets our array so it is empty and we can start over.
    selectedSquares = [];
}