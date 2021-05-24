function AddNewTest() {
    debugger;
    $.ajax({
        url: "../TestMaster/AddNewTest",
        type: "POST",
        success: function (Response) {
            $("#AddNewTestMaster").html(Response);
            $("#AddNewTestMaster").modal("show");
        }
    })
}