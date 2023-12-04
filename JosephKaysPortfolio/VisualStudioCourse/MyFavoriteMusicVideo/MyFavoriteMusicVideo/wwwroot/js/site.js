// This function waits until all content is loaded before firing
document.addEventListener("DOMContentLoaded", function () {
    // This gets the element to be used and assigns the sizes to use
    var myAnimation = document.getElementById("myAnimation");
    var containerWidth = 550;
    var containerHeight = 439;
    var squareSize = 50;

    // This defines the animation sequence by x y coordinates
    var animations = [
        { x: 0, y: containerHeight - squareSize },
        { x: containerWidth - squareSize, y: containerHeight - squareSize },
        { x: containerWidth - squareSize, y: 0 },
        { x: 0, y: 0 }
    ];

    // This function executes the animation sequence by using 'setTimeout' to delay each animation
    //by 'index'/2000 milliseconds, where 'index'is the index of animation in the 'animations' array
    function runAnimations() {
        // This function is a loop that iterates over each animation in the 'animations' array
        animations.forEach(function (animation, index) {
            setTimeout(function () {
                myAnimation.style.transform = "translate(" + animation.x + "px, " + animation.y + "px)";
            }, index * 2000);
        });

        // This function restarts the animation sequence in a loop
        setTimeout(runAnimations, animations.length * 2000);
    }

    // This line calls the runAnimation function to start
    runAnimations();
});