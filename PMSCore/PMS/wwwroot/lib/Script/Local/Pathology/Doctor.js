function AddNewDoctor() {
    // $("#AddDoctor").modal('show');
    //debugger;
    $.ajax({
        url: "../Doctor/AddDoctor",
        type: "POST",
        success: function (Response) {
            $("#AddDoctor").html(Response);
            $("#AddDoctor").modal("show");
        }
    });
}
function DeleteDoctorOperations(id, val) {
    bootbox.confirm("Do you want to delete this recored.?", function (result) {
        if (result) {
            DoctorOperations(id, val);
        }
    });
}
function DoctorOperations(Id, value) {
    debugger;
    var Edit = "E";
    var Delete = "D";
    if (value == "D" || value == "E") {
        $("#RowId").val(Id);
    }
    if (value == "E") {
        AddNewDoctor();
    }
    model = {
        RowId: $("#RowId").val(),
        DoctorName: $("#txtDoctorName").val(),
        Gender: $("#Gender").val(),
        MobileNo: $("#txtMobileNo").val(),
        EmailId: $("#txtEmail").val(),
        Address: $("#txtAddress").val(),
        Specialization: $("#Specialization").val(),
        Action: value,
    };
    $.ajax({
        url: "../Doctor/DoctorOperations",
        type: "POST",
        cache: false,
        async: true,
        data: model,

    }).done(function (response) {
        if (response.messageId == 1) {
            var box = bootbox.alert(response.messageText);
            box.find('.modal-body').removeClass(".modal-content").addClass(".modal-content alert-danger");
        }
        else if (response.messageId == 2) {
            var box = bootbox.alert(response.messageText);
            box.find('.modal-body').removeClass(".modal-content").addClass(".modal-content alert-success");
        }
        if (value == "E") {
            $("#RowId").val(response.rowId);
            $("#txtDoctorName").val(response.doctorName);
            $("#Gender").val(response.gender);
            $("#txtMobileNo").val(response.mobileNo);
            $("#txtEmail").val(response.emailId);
            $("#txtAddress").val(response.address);
            $("#Specialization").val(response.specialization);
        }
        if (value == "I" || value == "U" || value == "D") {
            ClearField();
        }
        EnabledDisabled(value);
    });
}
function ClearField() {

    $("#RowId").val("");
    $("#txtDoctorName").val("");
    $("#Gender").prop('selectedIndex', 1);
    $("#txtMobileNo").val("");
    $("#txtEmail").val("");
    $("#txtAddress").val("");
    $("#Specialization").prop('selectedIndex', 1);
}
function EnabledDisabled(val) {
    if (val == "E") {
        $("#btnCreate").prop('disabled', true);
        $("#btnUpdate").prop('disabled', false);
    }
    else {
        $("#btnCreate").prop('disabled', false);
        $("#btnUpdate").prop('disabled', true);
    }
}