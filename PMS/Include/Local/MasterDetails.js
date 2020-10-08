function MasterTypeData(id, val) {
    debugger;
    var token = $('input[name="__RequestVerificationToken"]').val();
    var headers = { '__RequestVerificationToken': token };
    var status = false;
    BootstrapDialog.show({

        title: 'WARNING',
        message: 'Are You Sure.?',
        type: BootstrapDialog.TYPE_WARNING,
        size: BootstrapDialog.SIZE_NORMAL,
        closable: true,
        draggable: true,
        closable: false,
        buttons: [{
            label: 'NO',
            cssClass: 'btn-warning',
            action: function (dialog, event) {
                dialog.close();
                allAction(id, val);
            }
        }, {
            label: 'YES',
            cssClass: 'btn-success',
                action: function (dialogRef) {
                    dialogRef.close();
                    allAction(id, val);
            },
        }]
    });
}
function allAction(Id, value) {
    debugger;
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
                HTMLList += '<tr><td>' + this.Name + '</td><td>' + this.Rate + '</td><td>' + this.PrintName + '</td>';
                HTMLList += '<td><a onclick="MasterTypeData(' + this.Id + ',U)" > Edit</a> |'
                HTMLList += '<a onclick = "MasterTypeData(' + this.Id + ',D)"> Delete</a> </td></tr> ';
            });
        }
        else {
            HTMLList += ' <tr><td colspan="4">Record Not Found</td >';
        }
        HTMLList += '</tbody>';
        HTMLList += '</table></div>'
        $("#MasterList").html(HTMLList);
        return false;
    });
}