function AddStaff(Id) {
    $.ajax({
        url: "../LabStaff/DisplayStaffForm/"+Id,
        type: "POST",
        success: function (Response) {
            $("#AddStaff").html(Response);
            $("#AddStaff").modal("show");
            $("#txtDOB").datepicker();
        }
    })
}
function DeleteLabStaffData(id, val) {
    bootbox.confirm("Do you want to delete this recored.?", function (result) {
        if (result) {
            DeleteStaffData(id, val);
        }
    });
}

function DeleteStaffData(Id, value) {
    model = {
        RowId: Id,
        Action: value,
    };
    $.ajax({
        url: "../LabStaff/DeleteStaffData",
        type: "POST",
        cache: false,
        async: true,
        data: model,

    }).done(function (response) {
        if (response.messageId == 1) {
            var box = bootbox.alert(response.messageText, function () {
                status = false;
            });
            box.find('.modal-body').removeClass(".modal-content").addClass(".modal-content alert-danger");
        }
        else if (response.messageId == 2) {
            var box = bootbox.alert(response.messageText, function () {
                if (response.result == 'D') {
                    window.location.href = response.url;
                }
            });
            box.find('.modal-body').removeClass(".modal-content").addClass(".modal-content alert-success");
        }
    });
}