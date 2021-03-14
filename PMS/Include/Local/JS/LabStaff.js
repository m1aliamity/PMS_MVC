function NumericValue(e,value) {
    var keyCode = e.keyCode || e.which;
    var regex = /^[0-9]+$/;
    var isValid = regex.test(String.fromCharCode(keyCode));
    if (!isValid) {
        alert("Only Numeric and Comma , allowed.");
        return false
    }
    if (value.length > 10) {
        alert("Only Numeric and Comma , allowed.");
        return false;
    }
    return isValid;
}

function LabStaffOperations(Id, value) {
    debugger;
    var token = $('input[name="__RequestVerificationToken"]').val();
    var headers = { '__RequestVerificationToken': token };
    var status = false;
    var Edit = "E";
    var Delete = "D";
    if (value == "D" || value == "E") {
        $("#Id").val(Id);
    }
    if (value == "D") {
        status = confirm('Are you sure? want to delete');
        if (!status) {
            return false;
        }
    }
    model = {
        Id: $("#Id").val(),
        FirstName :  $("#FirstName").val(),
        LastName : $("#LastName").val(),
        MobileNo :  $("#MobileNo").val(),
        EmailId :  $("#EmailId").val(),
        Gender :  $("#Gender").val(),
        Religion :  $("#Religion").val(),
        MritalStatus : $("#MritalStatus").val(),
        SpauseName :  $("#SpauseName").val(),
        DateOfBirth :  $("#DateOfBirth").val(),
        AnniversaryDate :  $("#AnniversaryDate").val(),
        StaffType :  $("#StaffType").val(),
        Address :  $("#Address").val(),
        Action: value,
    };
    $.ajax({
        url: "../LabStaff/LabStaffOperations",
        type: "POST",
        cache: false,
        async: true,
        data: model,
        headers: headers,
    }).done(function (response) {
        if (response.MessageId == 1) {

            alert(response.MessageText);
        }
        if (value == "E") {
            debugger;
            $("#btnCreate").css("display", "none");
            $("#btnUpdate").css("display", "block");
            $("#Id").val(response.Id);
            $("#CompanyName").val(response.CompanyName);
            $("#SloganName").val(response.SloganName);
            $("#PhoneNo").val(response.PhoneNo);
            $("#EmailId").val(response.Email);
            $("#WebSite").val(response.WebSite);
            $("#StreetAddress").val(response.StreetAddress);
            $("#ShowDetail").val(response.ShowDetail);
            $("#IsActive").val(response.IsActive);
        }
        var ListHtml = ''
        ListHtml += '<div class="col-sm-12">';
        ListHtml += '<table class="table">';
        ListHtml += '<thead><tr><th scope="col">Lab Name</th><th scope="col">Slogan Name</th><th scope="col">Address</th><th scope="col">Phone No.</th><th scope="col">Email Id</th><th scope="col">Website</th><th scope="col">Show Details</th><th scope="col">Is Active</th><th scope="col">Action</th></tr></thead>';
        ListHtml += '<tbody>';
        if (response.CompanyList.length > 0) {
            $.each(response.CompanyList, function () {
                ListHtml += '<tr><td>' + this.CompanyName + '</td><td>' + this.SloganName + '</td><td>' + this.StreetAddress + '</td><td>' + this.PhoneNo + '</td><td>' + this.EmailId + '</td><td>' + this.WebSite + '</td><td>' + this.ShowDetail + '</td><td>' + this.IsActive + '</td><td><a href="#" onclick="CompanyOperation(' + this.Id + ',\'' + Edit + '\');"> Edit</a> | <a href="#" onclick="CompanyOperation(' + this.Id + ',\'' + Delete + '\');"> Delete</a></td></tr>';
            });
        }
        else {
            ListHtml += '<tr><td colspan="4"> Record Not Found ...</td></tr>';
        }
        ListHtml += '</tbody>';
        ListHtml += '</table>';
        ListHtml += '</div>';
        $("#CompanyList").empty();
        $("#CompanyList").html(ListHtml);
        if (value == "I" || value == "U" || value == "D") {
            //clearfield();
        }
    });
}
function clearfield() {
    $("#btnCreate").css("display", "block");
    $("#btnUpdate").css("display", "none");
    $("#Id").val(0);
    $("#CompanyName").val('');
    $("#SloganName").val('');
    $("#PhoneNo").val('');
    $("#EmailId").val('');
    $("#WebSite").val('');
    $("#StreetAddress").val('');
    $("#ShowDetail").val(false);
    $("#IsActive").val(false);
}
