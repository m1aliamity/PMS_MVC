function AddNewDoctor() {
    $("#AddDoctor").modal('show');
    //debugger;
    //$.ajax({
    //    url: "../Doctor/AddDoctor",
    //    type: "POST",
    //    success: function (Response) {
    //        $("#AddDoctor").html(Response);
    //        $("#AddDoctor").modal("show");
    //    }
    //})
}
function DoctorOperations(Id, value) {
    debugger;
    var Edit = "E";
    var Delete = "D";
    if (value == "D" || value == "E") {
        $("#RowId").val(Id);
    }
    if (value == "D") {
        status = confirm('Are you sure? want to delete');
        if (!status) {
            return false;
        }
    }
    if (value == "E")
    {
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
            alert(response.messageText);
        }
        else {
            if (value == "E") {
                $("#RowId").val(response.rowId);
                $("#txtDoctorName").val(response.doctorName);
                $("#Gender").val(response.gender);
                $("#txtMobileNo").val(response.mobileNo);
                $("#txtEmail").val(response.emailId);
                $("#txtAddress").val(response.address);
                $("#Specialization").val(response.specialization);
            }
            //SetDataTable();
            if (value == "I" || value == "U" || value == "D") {
                alert(response.messageText);
                ClearField();
            }
            EnabledDisabled(value);
        }
    });
}
function SetDataTable() {
    $('#example').DataTable({
        responsive: {
            details: {
                display: $.fn.dataTable.Responsive.display.modal({
                    header: function (row) {
                        var data = row.data();
                        // return 'Details for ' + data[0] + ' ' + data[1];
                        return 'Details for ' + data[0];
                    }
                }),
                renderer: $.fn.dataTable.Responsive.renderer.tableAll()
            }
        }
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