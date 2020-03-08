

$(document).ready(function () {


    $("#btnPolicz").click(function () {

        //.... tutaj my wywołąmy inną stronę asynchronicznie 
        // uzywajac technologii ajax

        $.ajax({
            method: "POST",
            url: "Serwis.aspx",
            data: { name: "John", location: "Boston" }
        })
            .done(function (msg) {
                alert("Data Saved: " + msg);
            });



    });


});