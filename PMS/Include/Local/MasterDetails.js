function MasterTypeData(value) {
    debugger;
    var token = $('input[name="__RequestVerificationToken"]').val();
    var headers = { '__RequestVerificationToken': token };
    model = {
        MID: $("#MID").val(),
        Name: $("#Name").val(),
        Rate: $("#Rate").val(),
        PrintName: $("#PrintName").val(),
        Action: value,
    };
    $.ajax({
        url: "../MasterData/GetMasterTypeData",
        type: "POST",
        data: model,
        headers: headers,
    }).done(function (response) {

        $("#MasterList").empty();
        var HTMLList = '';
        HTMLList += '<div class="col-md-10"> <table class="table">';
        HTMLList += '<thead><tr><th scope="col">Name</th><th scope="col">Rate</th><th scope="col">Print Name</th><th scope="col">Action</th></tr ></thead ></tbody>';
        if (response.MasterDetails.length > 0) {
            $.each(response.MasterDetails, function () {
                HTMLList += '<tr><td>' + this.Name + '</td><td>' + this.Rate + '</td><td>' + this.PrintName + '</td><td>' + this.PrintName + '</td></tr>';
            });
        }
        else {
            HTMLList += ' <tr><td colspan="4">Record Not Found</td >';
        }
        HTMLList += '</tbody>';
        HTMLList += '</table></div>'
        $("#MasterList").html(HTMLList);
    });
}