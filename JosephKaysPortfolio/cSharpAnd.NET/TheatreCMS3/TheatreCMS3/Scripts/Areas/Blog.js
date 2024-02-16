$(document).ready(function () {
    $('#delete-author').click(function () {
        var authorToDelete = $(this).data('author-id');

        if (confirm("Are you sure you want to delete the author?")) {
            $.ajax({
                url: '/Blog/BlogAuthors/DeleteConfirmed/' + authorToDelete,
                type: 'POST',  
                success: function (result) {
                    console.log(result);

                    var jsonString = JSON.stringify(result);

                    alert(jsonString);

                    var x = document.getElementById("author-container-" + authorToDelete);
                    if (x.style.display === "none") {
                        x.style.display = "block";
                    } else {
                        x.style.display = "none";
                    }
                },
                error: function (err) {
                    console.log("Error:", err);
                }
            });
        }
    });
});
