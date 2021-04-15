function ValidateUser() {
    //var token = $('input[name="__RequestVerificationToken"]').val();
    //var headers = { '__RequestVerificationToken': token };
    debugger;
    model = {
        UserName: $("#txtUserName").val(),
        Password: $("#txtPassword").val(),
    };
    $.ajax({
        url: "../User/UserLogin",
        type: "POST",
        cache: false,
        async: true,
        //dataType: 'json',
        //contentType: dataType,
        data: model,

    }).done(function (response) {
        if (response.messageId == 1) {
            alert(response.messageText);
        }
    });
}