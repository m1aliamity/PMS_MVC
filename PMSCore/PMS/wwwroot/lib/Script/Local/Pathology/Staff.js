function AddStaff() {
    $.ajax({
        url: "../LabStaff/AddStaff",
        type: "POST",
        success: function (Response) {
            $("#AddStaff").html(Response);
            $("#AddStaff").modal("show");
            $("#txtDOB").datepicker();
        }
    })
}
function DeleteLabStaffOperations(id, val) {
    bootbox.confirm("Do you want to delete this recored.?", function (result) {
        if (result) {
            LabStaffOperations(id, val);
        }
    });
}
function LabStaffOperations(Id, value) {
    debugger;
    var Edit = "E";
    var Delete = "D";
    if (value == "D" || value == "E") {
        $("#RowId").val(Id);
    }
    if (value == "E") {
        AddStaff();
    }
    model = {
        RowId: $("#RowId").val(),
        FirstName: $("#txtFname").val(),
        LastName: $("#txtLname").val(),
        Gender: $("#Gender").val(),
        DOB: $("#txtDOB").val(),
        MobileNo: $("#txtMobileNo").val(),
        EmailId: $("#txtEmail").val(),
        MeritalStatus: $("#MeritalStatus").val(),
        EmployeeTypeId: $("#EmployeeTypeId").val(),
        Address: $("#txtAddress").val(),
        Status: $("#dpdStatus").val(),
        Action: value,
    };
    $.ajax({
        url: "../LabStaff/CompanyOperatons",
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
            debugger;
            $("#RowId").val(response.rowId);
            $("#txtFname").val(response.firstName);
            $("#txtLname").val(response.lastName);
            $("#Gender").vapropl('selectedValue',response.gender);
            $("#txtDOB").val(response.dOB);
            $("#txtMobileNo").val(response.mobileNo);
            $("#txtEmail").val(response.emailId);
            $("#MeritalStatus").prop('selectedValue',response.meritalStatus);
            $("#EmployeeTypeId").prop('selectedValue',response.employeeTypeId);
            $("#txtAddress").val(response.address);
            $("#dpdStatus").prop('selectedValue',response.status);
        }
        if (value == "I" || value == "U" || value == "D") {
            ClearField();
        }
        EnabledDisabled(value);
    });
}
function ClearField() {
    $("#RowId").val("");
    $("#txtFname").val("");
    $("#txtLname").val("");
    $("#Gender").prop('selectedValue', 0);
    $("#txtDOB").val("");
    $("#txtMobileNo").val("");
    $("#txtEmail").val("");
    $("#MeritalStatus").prop('selectedValue', 0);
    $("#EmployeeTypeId").prop('selectedValue', 0);
    $("#txtAddress").val("");
    $("#dpdStatus").prop('selectedValue', 0);
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