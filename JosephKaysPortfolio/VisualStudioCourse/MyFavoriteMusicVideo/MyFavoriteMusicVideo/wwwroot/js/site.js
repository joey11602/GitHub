document.addEventListener("DOMContentLoaded", function () {
    var myAnimation = document.getElementById("myAnimation");
    var containerWidth = 550;
    var containerHeight = 439;
    var squareSize = 50;

    // Define the animation sequence
    var animations = [
        { x: 0, y: containerHeight - squareSize },
        { x: containerWidth - squareSize, y: containerHeight - squareSize },
        { x: containerWidth - squareSize, y: 0 },
        { x: 0, y: 0 }
    ];

    // Function to execute the animations
    function runAnimations() {
        animations.forEach(function (animation, index) {
            setTimeout(function () {
                myAnimation.style.transform = "translate(" + animation.x + "px, " + animation.y + "px)";
            }, index * 2000); // 2000ms (2 seconds) delay for each animation
        });

        // Repeat the animations
        setTimeout(runAnimations, animations.length * 2000);
    }

    // Start the animations
    runAnimations();
});