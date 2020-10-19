function MasterTypeData(Id, value) {
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
        MID: $("#MID").val(),
        Name: $("#Name").val(),
        Rate: $("#Rate").val(),
        PrintName: $("#PrintName").val(),
        Action: value,
    };
    $.ajax({
        url: "../MasterData/MasterDetailsOperations",
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
            $("#btnCreate").css("display", "none");
            $("#btnUpdate").css("display", "block");
            $("#Id").val(response.Id);
            $("#Name").val(response.Name);
            $("#Rate").val(response.Rate);
            $("#PrintName").val(response.PrintName);
        }
        var ListHtml = ''
        ListHtml += '<div class="col-sm-12">';
        ListHtml += '<table class="table table-sm table-Success">';
        ListHtml += '<thead><tr><th scope="col">Name</th><th scope="col">Rate</th><th scope="col">Print Name</th><th scope="col">Action</th></tr></thead>';
        ListHtml += '<tbody>';
        if (response.MasterDetails.length > 0) {
            $.each(response.MasterDetails, function () {
                ListHtml += '<tr><td>' + this.Name + '</td><td>' + this.Rate + '</td><td>' + this.PrintName + '</td><td><a href="#" onclick="MasterTypeData(' + this.Id + ',\'' + Edit + '\');"> Edit</a> | <a href="#" onclick="MasterTypeData(' + this.Id + ',\'' + Delete + '\');"> Delete</a></td></tr>';
            });
        }
        else {
            ListHtml += '<tr><td colspan="6"> Record Not Found ...</td></tr>';
        }
        ListHtml += '</tbody>';
        ListHtml += '</table>';
        ListHtml += '</div>';
        $("#MasterList").empty();
        $("#MasterList").html(ListHtml);
        if (value == "I" || value == "U" || value == "D") {
            clearfield();
        }
    });
}
function clearfield() {
    $("#btnCreate").css("display", "block");
    $("#btnUpdate").css("display", "none");
    $("#Id").val(0);
    $("#Name").val('');
    $("#Rate").val(0.0);
    $("#PrintName").val('');
}