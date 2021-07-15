AjaxAddOrUpdateData = form => {
var status=false;
    $.ajax({
        type: 'POST',
        url: form.action,
        data: new FormData(form),
        contentType: false,
        processData: false,
        success: function (response) {
            if (response.messageId == 1) {
                var box = bootbox.alert(response.messageText, function () {
                    status = false;
                });
                box.find('.modal-body').removeClass(".modal-content").addClass(".modal-content alert-danger");
            }
            else if (response.messageId == 2) {
                var box = bootbox.alert(response.messageText, function () {
                    if (response.result == 'U') {
                        window.location.href = response.url;
                    }
                    else {
                        $('form#frmData').trigger("reset"); //Line1
                        $('form#frmData select').trigger("change");}
                });
                box.find('.modal-body').removeClass(".modal-content").addClass(".modal-content alert-success");

            }
        }
    });
    return status;
}
jQueryAjaxDelete = form => {
    var status = false;
    bootbox.confirm("Do you want to delete this recored.?", function (result) {
        if (result) {
            $.ajax({
                type: 'POST',
                url: form.action,
                data: new FormData(form),
                contentType: false,
                processData: false,
                success: function (response) {
                    if (response.messageId == 1) {
                        var box = bootbox.alert(response.messageText, function () {
                            status = false;
                        });
                        box.find('.modal-body').removeClass(".modal-content").addClass(".modal-content alert-danger");
                    }
                    else if (response.messageId == 2) {
                        var box = bootbox.alert(response.messageText, function () {
                            if (response.result == 'D') {
                                window.location.href = response.url;
                            }
                        });
                        box.find('.modal-body').removeClass(".modal-content").addClass(".modal-content alert-success");

                    }
                }
            });
        }
    });
    return status;
}