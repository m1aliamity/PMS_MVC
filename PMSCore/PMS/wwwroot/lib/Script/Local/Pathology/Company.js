function AddCompany() {
    debugger;
    $.ajax({
        url: "../Company/AddCompany",
        type: "POST",
        success: function (Response) {
            $("#AddCompany").html(Response);
            $("#AddCompany").modal("show");
        }
    });
}
function DeleteCompanyOperation(id, val) {
    bootbox.confirm("Do you want to delete this recored.?", function (result) {
        if (result) {
            CompanyOperation(id, val);
        }
    });
}
function CompanyOperation(Id, value) {
    debugger;
    //var token = $('input[name="__RequestVerificationToken"]').val();
    //var headers = { '__RequestVerificationToken': token };
    var Edit = "E";
    var Delete = "D";
    if (value == "D" || value == "E") {
        $("#RowId").val(Id);
    }
    if (value == "E") {
        AddCompany();
    }
    model = {
        RowId: $("#RowId").val(),
        CompanyName: $("#txtLabName").val(),
        SloganName: $("#txtLabSloganName").val(),
        PhoneNo: $("#txtPhoneNo").val(),
        EmailId: $("#txtEmailId").val(),
        WebSite: $("#txtWebSite").val(),
        Address: $("#txtAddress").val(),
        Status: $("#dpdStatus").val(),
        LabLogoPath: $("#atchLabLogo").val(),
        Action: value,
    };
    $.ajax({
        url: "../Company/CompanyOperatons",
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
            $("#txtLabName").val(response.companyName);
            $("#txtLabSloganName").val(response.sloganName);
            $("#txtPhoneNo").val(response.phoneNo);
            $("#txtEmailId").val(response.emailId);
            $("#txtWebSite").val(response.webSite);
            $("#txtAddress").val(response.Address);
            $("#dpdStatus").val(response.status);
        }
        if (value == "I" || value == "U" || value == "D") {
            ClearField();
        }
        EnabledDisabled(value);
    });
}
function ClearField() {
    $("#txtLabName").val("");
    $("#txtLabSloganName").val("");
    $("#txtPhoneNo").val("");
    $("#txtEmailId").val("");
    $("#txtWebSite").val("");
    $("#txtAddress").val("");
    $("#dpdStatus").prop('selectedIndex', 1);
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