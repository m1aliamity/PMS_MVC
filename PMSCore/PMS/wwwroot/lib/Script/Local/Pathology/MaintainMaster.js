function MaintainMasterOperation(Id, value) {
    //var token = $('input[name="__RequestVerificationToken"]').val();
    //var headers = { '__RequestVerificationToken': token };
    var Edit = "E";
    var Delete = "D";
    var MID = $("#MID").val();
    ColumnsAdjustment(MID);
    if (value == "D" || value == "E") {
        $("#RowId").val(Id);
    }
    if (value == "D") {
        status = confirm('Are you sure? want to delete');
        if (!status) {
            return false;
        }
    }
    model = {
        RowId: $("#RowId").val(),
        MID: $("#MID").val(),
        Name: $("#txtName").val(),
        Rate: $("#txtRate").val(),
        PrintName: $("#txtPrintName").val(),
        Status: $("#dpdStatus").val(),
        Remarks: $("#txtRemarks").val(),
        Action: value,
    };
    $.ajax({
        url: "../MaintainMaster/MaintainMasterOperation",
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
            if (value == "E") {
                $("#RowId").val(response.rowId);
                $("#txtName").val(response.name);
                $("#txtRate").val(response.rate);
                $("#txtPrintName").val(response.printName);
                $("#dpdStatus").val(response.status);
                $("#txtRemarks").val(response.remarks);
            }
            $("#tblMasterList").empty();
            var ListHtml = '';
            ListHtml += '<table id="example" class="display nowrap cell-border" style="width:100%"><thead><tr>';
            /*            ListHtml += '<table id="example" class="display" style="width:100%"><thead><tr>';*/
            ListHtml += '<th scope="col">Name</th>';
            ListHtml += '<th scope="col">Print Name</th>';
            if (MID == 7) {
                ListHtml += '<th scope="col">Rate</th>';
            }
            ListHtml += '<th scope="col">Status</th>';
            ListHtml += '<th scope="col">Remarks</th>';
            ListHtml += '<th scope="col">Action</th>';
            ListHtml += '</tr></thead> ';
            ListHtml += '<tbody>';
            if (response.masterDetailsList.length > 0) {
                $.each(response.masterDetailsList, function () {
                    ListHtml += '<tr><td>' + this.name + '</td>'
                    ListHtml += '<td>' + this.printName + '</td>'
                    if (MID == 7) {
                        ListHtml += '<td> ' + this.rate + '</td >'
                    }
                    ListHtml += '<td>' + this.statusName + '</td><td>' + this.remarks + '</td ><td><a href="#" class="class="fa fa-pencil"" onclick="MaintainMasterOperation(' + this.rowId + ',\'' + Edit + '\');"> Edit</a> | <a href="#" class="class="fa fa-trash" onclick="MaintainMasterOperation(' + this.rowId + ',\'' + Delete + '\');"> Delete</a></td>';
                    ListHtml += '</tr > ';

                });
                ListHtml += '</tbody> </table>';
            }
            else {
                ListHtml += '<tr><td colspan="7"> Record Not Found ...</td></tr>';
            }
            ListHtml += '</tbody>';
            ListHtml += '</table>';
            $("#tblMasterList").html(ListHtml);
            SetDataTable();
        if (value == "I" || value == "U" || value == "D") {
            ClearField();
        }
        EnabledDisabled(value);
    });
}
function SetDataTable() {
    $('#example').DataTable({
        responsive: {
            details: {
                display: $.fn.dataTable.Responsive.display.modal({
                    header: function (row) {
                        var data = row.data();
                        // return 'Details for ' + data[0] + ' ' + data[1];
                        return 'Details for ' + data[0];
                    }
                }),
                renderer: $.fn.dataTable.Responsive.renderer.tableAll()
            }
        }
    });
}
function ClearField() {
    $("#RowId").val("");
    $("#txtName").val("");
    $("#txtRate").val("0");
    $("#txtPrintName").val("");
    $("#dpdStatus").prop('selectedIndex', 1);;
    $("#txtRemarks").val("");
}
function EnabledDisabled(val) {
    if (val == "E") {
        $("#btnCreate").prop('disabled', true);
        $("#btnUpdate").prop('disabled', false);
    }
    else {
        $("#btnCreate").prop('disabled', false);
        $("#btnUpdate").prop('disabled', true);
    }
}
function ColumnsAdjustment(mid) {
    debugger;
    if (mid == 7) {
        $("#lblRate").show();
        $("#divRate").show();
        $("#lblStatus").removeClass("col-sm-3 col-form-label col-form-label-sm").addClass("col-sm-2 col-form-label col-form-label-sm");
        $("#divStatus").removeClass("col-sm-9").addClass("col-sm-4");
    }
    else {
        $("#lblRate").hide();
        $("#divRate").hide();
        $("#lblStatus").removeClass("col-sm-2 col-form-label col-form-label-sm").addClass("col-sm-3 col-form-label col-form-label-sm");
        $("#divStatus").removeClass("col-sm-4").addClass("col-sm-9");
    }
}
$('#success2').click(function () {

});