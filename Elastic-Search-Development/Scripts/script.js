$(document).ready(function () {
    $("#btnsearch").on("click", function () {
        debugger
        if ($("#txtjobTitle").val() === "" && $("#txtnationalIDNumber").val() === "") {
            alert("Provide Details to Search !");
        }
        else {
            var jobTitle = $.trim($("#txtjobTitle").val());
            var nationalIDNumber = $.trim($("#txtnationalIDNumber").val());

            $.ajax({
                type: "POST",
                url: '/Search/Search',
                data: { jobTitle: jobTitle, nationalIDNumber: nationalIDNumber },
                success: function (data) {debugger
                   // var tableData = data.filter("#success");
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