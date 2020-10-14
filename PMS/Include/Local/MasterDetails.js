function MasterTypeData(Id, value) {
    debugger;
    var token = $('input[name="__RequestVerificationToken"]').val();
    var headers = { '__RequestVerificationToken': token };
    var status = false;
    var Edit = "E";
    var Delete = "D"
    if (value == "D" || value == "E") {
        $("#Id").val(Id);
    }
    if (value == "D")
    {
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
        url: "../MasterData/MasterDataList",
        type: "POST",
        cache: false,
        async: true,
        data: model,
        headers: headers,
    }).done(function (response) {
        if (response.MessageId == 1)
        {
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
        ListHtml += '<div class="col-md-offset-2 col-md-10">';
        ListHtml += '<table class="table">';
        ListHtml += '<thead><tr><th scope="col">Name</th><th scope="col">Rate</th><th scope="col">Print Name</th><th scope="col">Action</th></tr></thead>';
        ListHtml += '<tbody>';
        if (response.MasterDetails.length > 0) {
            $.each(response.MasterDetails, function () {
                ListHtml += '<tr><td>' + this.Name + '</td><td>' + this.Rate + '</td><td>' + this.PrintName + '</td><td><a href="#" onclick="MasterTypeData(' + this.Id + ',\'' + Edit + '\');"> Edit</a> | <a href="#" onclick="MasterTypeData(' + this.Id + ',\'' + Delete + '\');"> Delete</a></td></tr>';
            });
        }
        else {
            ListHtml += '<tr><td colspan="4"> Record Not Found ...</td></tr>';
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
//var LobHtml = '';
//if (data.SubLOBCollection.length > 0) {
//    LobHtml += '<table id="tblcphIBCM_chklstLob" name="tblcphIBCM_chklstLob" class="checkBoxList">';
//    LobHtml += '<tbody>';
//    LobHtml += '<tr><td><input id="cphIBCM_ChkSelectAll" type="checkbox" name="cphIBCM_ChkSelectAll" onclick="SelectAllLob();"><label >All</label></td></tr>';
//    $.each(data.SubLOBCollection, function () {
//        LobHtml += '<tr><td><input onclick="SelectChangeLob();" id="CkdIBCM_chklstLob_' + this.Value + '" type="checkbox" name="CkdIBCM_chklstLob" tabindex="5" value="' + this.Value + '"><label id="CkdIBCM_chklstLobtext_' + this.Value + '">' + this.Text + '</label></td></tr>';
//    });
//    LobHtml += '</tbody>';
//    LobHtml += '</table>';

//} else {
//    LobHtml += '<table id="cphIBCM_chklstLob" class="checkBoxList">';
//    LobHtml += '<tbody>';
//    LobHtml += '<tr>';
//    LobHtml += '<td><label>Lob Not Selected.</label></td> </tr></tbody>';
//    LobHtml += '</table>';
//}
//$("#SubLOBCollection_Id").html(LobHtml);

//    BootstrapDialog.show({
//        title: 'WARNING',
//        message: 'Are You Sure.?',
//        type: BootstrapDialog.TYPE_WARNING,
//        size: BootstrapDialog.SIZE_NORMAL,
//        closable: true,
//        draggable: true,
//        closable: false,
//        buttons: [{
//            label: 'NO',
//            cssClass: 'btn-warning',
//            action: function (dialog, event) {
//                dialog.close();
//                allAction(id, val);
//            }
//        }, {
//            label: 'YES',
//            cssClass: 'btn-success',
//                action: function (dialogRef) {
//                    dialogRef.close();
//                    allAction(id, val);
//            },
//        }]
//    });
//}