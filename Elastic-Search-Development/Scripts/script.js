$(document).ready(function () {
    $('#customerModal').modal('hide');

    $("#btnsearch").on("click", function (e) {
        e.stopPropagation();

        if ($("#txtCustomer").val() === "") {
            var r = confirm("Provide Details to Search !");
            e.stopPropagation();
        }
        else {
            var customerInfo = $.trim($("#txtCustomer").val());

            $.ajax({
                type: "POST",
                url: '/Search/Search',
                data: { customerInfo: customerInfo },
                success: function (data) {
                    e.preventDefault();
                    $('body').html(data);
                    $('#customerInfoValue').text(customerInfo);
                    $('#customerModal').modal('hide');
                },
                error: function (xhr, err) {
                    alert("readyState: " + xhr.readyState + "\nstatus: " + xhr.status);
                    alert("responseText: " + xhr.responseText);
                }

            });
        }
    });
});