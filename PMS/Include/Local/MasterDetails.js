function MasterTypeData(Id, value) {
    debugger;
    var token = $('input[name="__RequestVerificationToken"]').val();
    var headers = { '__RequestVerificationToken': token };
    var status = false;
    if (value == "D")
    {
        status = confirm('Are you sure? want to delete');
        if (status = false)
             return false;
    }
    model = {
        MID: $("#MID").val(),
        Name: $("#Name").val(),
        Rate: $("#Rate").val(),
        PrintName: $("#PrintName").val(),
        Action:value,
    };
    $.ajax({
        url: "../MasterData/MasterDataList",
        type: "POST",
        data: model,
        cache: false,
        headers: headers,
    }).done(function (response) {
        //$("#MasterList").empty();
        $("#MasterList").html(response);
    });
}

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