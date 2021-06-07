function AddStaff() {
    debugger;
    $.ajax({
        url: "../LabStaff/AddStaff",
        type: "POST",
        success: function (Response) {
            $("#AddStaff").html(Response);
            $("#AddStaff").modal("show");
        }
    })
}