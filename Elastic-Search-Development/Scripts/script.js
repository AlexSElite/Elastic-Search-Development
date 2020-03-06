$(document).ready(function () {
    $("#btnsearch").on("click", function () {
        debugger
        if ($("#txtCustomer").val() === "") {
            alert("Provide Details to Search !");
        }
        else {
            var firstName = $.trim($("#txtCustomer").val());

            $.ajax({
                type: "POST",
                url: '/Search/Search',
                data: { firstName: firstName},
                success: function (data) {debugger
                    $('body').html(data);
                },
                error: function (xhr, err) {
                    alert("readyState: " + xhr.readyState + "\nstatus: " + xhr.status);
                    alert("responseText: " + xhr.responseText);
                }

            });
        }
    });
});