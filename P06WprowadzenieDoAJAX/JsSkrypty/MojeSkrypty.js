

$(document).ready(function () {


    $("#btnPolicz").click(function () {

        //.... tutaj my wywołąmy inną stronę asynchronicznie 
        // uzywajac technologii ajax

        var liczba1 = $("#txtLiczba1").val();
        var liczba2 = $("#txtLiczba2").val();

        $.ajax({
            method: "POST",
            url: "Serwis.aspx",
            data: { liczba1Parametr: liczba1, liczba2Parametr: liczba2 }
        })
            .done(function (msg) {
                //alert("Data Saved: " + msg);
                $("#lblWynik").text(msg);
            });



    });


});