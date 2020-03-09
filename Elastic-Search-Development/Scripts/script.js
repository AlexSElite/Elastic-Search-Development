$(document).ready(function () {
    $('#customerModal').modal('hide');

    $("#btnsearch").on("click", function (e) {
        debugger
        if ($("#txtCustomer").val() === "") {
            var r = confirm("Provide Details to Search !");
            e.stopPropagation();
        }
        else {
            var customerName = $.trim($("#txtCustomer").val());

            $.ajax({
                type: "POST",
                url: '/Search/Search',
                data: { customerName: customerName },
                success: function (data) {
                    debugger
                    e.preventDefault();
                    $('body').html(data);
                    $('#customerNameValue').text(customerName);
                    $('#customerModal').modal('show');
                },
                error: function (xhr, err) {
                    alert("readyState: " + xhr.readyState + "\nstatus: " + xhr.status);
                    alert("responseText: " + xhr.responseText);
                }

            });
        }
    });
});