//Waits for document to completely load before running scripts
$(document).ready(function () {
    //Listener for the delete button
    $('#delete-author').click(function () {
        var authorToDelete = $(this).data('author-id');
        //The Modal pop up for confirmation
        if (confirm("Are you sure you want to delete the author?")) {
            //The ajax function to access the data base
            $.ajax({
                url: '/Blog/BlogAuthors/DeleteConfirmed/' + authorToDelete,
                type: 'POST',  
                success: function (result) {
                    //for debugging
                    console.log(result);

                    var jsonString = JSON.stringify(result);
                    //Pop up confirmation to the user
                    alert(jsonString);
                    //JavaScript to change the CSS to hide the deleted author
                    var x = document.getElementById("author-container-" + authorToDelete);
                    if (x.style.display === "none") {
                        x.style.display = "block";
                    } else {
                        x.style.display = "none";
                    }
                },
                //Handle Errors
                error: function (err) {
                    console.log("Error:", err);
                }
            });
        }
    });
});
