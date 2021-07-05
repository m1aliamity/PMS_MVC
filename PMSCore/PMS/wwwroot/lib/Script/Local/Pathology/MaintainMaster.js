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
        /*bootbox.alert(response.messageText);*/
            var box = bootbox.alert("Hello world!");
            box.find('.modal-body').removeClass(".modal-content").addClass(".modal-content alert-success"); // (thanks Mark B)
            /*box.find(".btn-primary").removeClass("btn-primary").addClass("btn-danger");*/
            //bootbox.dialog("Error in task", {
            //    "label": "Ok",
            //    "class": "success",   // or primary, or success, or nothing at all
            //    "callback": function () {
            //        //console.log("great success");
            //    }
            //});
            //alert(response.messageText);
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
        ListHtml += ' <div class="widget widget-simple widget-table">';
        ListHtml += '<table id="exampleDTC" class="table table-striped table-content table-condensed boo-table table-hover bg-green-light">';
        ListHtml += '<caption class="caption-m"><span>Master List</span></caption>';
        ListHtml += '<thead><tr><th scope="col">Name<span class="column-sorter"></span></th>';
        ListHtml += '<th scope="col">Print Name<span class="column-sorter"></span></th>';
        if (MID == 7) {
            ListHtml += '<th scope="col">Rate<span class="column-sorter"></span></th>';
        }
        ListHtml += '<th scope="col">Status<span class="column-sorter"></span></th>';
        ListHtml += '<th scope="col">Remarks<span class="column-sorter"></span></th>';
        ListHtml += '<th scope="col">Action<span class="column-sorter"></span></th>';
        ListHtml += '</tr></thead> ';
        ListHtml += '<tbody>';
        if (response.masterDetailsList.length > 0) {
            $.each(response.masterDetailsList, function () {
                ListHtml += '<tr><td style="font-size: 11px">' + this.name + '</td>'
                ListHtml += '<td style="font-size: 11px">' + this.printName + '</td>'
                if (MID == 7) {
                    ListHtml += '<td> ' + this.rate + '</td >'
                }
                ListHtml += '<td>' + this.statusName + '</td><td>' + this.remarks + '</td><td><a title="Edit" data-toggle="tooltip" onclick="MaintainMasterOperation(' + this.rowId + ',\'' + Edit + '\');"><i class="fa fa-pencil"></i></a> | <a title="Delete" data-toggle="tooltip" onclick="MaintainMasterOperation(' + this.rowId + ',\'' + Delete + '\');"><i <i class="fa fa-trash"></i></i></a></td>';
                ListHtml += '</tr > ';
            });
            ListHtml += '</tbody> </table>';
        }
        else {
            ListHtml += '<tr><td colspan="7"> Record Not Found ...</td></tr>';
        }
        ListHtml += '</tbody>';
        ListHtml += '</table>';
        ListHtml += '</div>';
        $("#tblMasterList").html(ListHtml);
        //datatable();
        if (value == "I" || value == "U" || value == "D") {
            ClearField();
        }
        EnabledDisabled(value);
    });
}
function ClearField() {
    $("#RowId").val("");
    $("#txtName").val("");
    $("#txtRate").val("0");
    $("#txtPrintName").val("");
    $("#dpdStatus").prop('selectedIndex', 1);
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
        $("#ListRate").show();
    }
    else {
        $("#ListRate").hide();
    }
}
function MaintaiTestHeadOperation(Id, value) {
    //var token = $('input[name="__RequestVerificationToken"]').val();
    //var headers = { '__RequestVerificationToken': token };
    var Edit = "E";
    var Delete = "D";
    var DepartmentId = $("#DepartmentId").val();
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
        DepartmentId: $("#DepartmentId").val(),
        Name: $("#txtName").val(),
        PrintName: $("#txtPrintName").val(),
        Status: $("#dpdStatus").val(),
        Action: value,
    };
    $.ajax({
        url: "../MaintainMaster/TestHeadOperation",
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
            $("#txtPrintName").val(response.printName);
            $("#dpdStatus").val(response.status);
        }
        $("#tblDepartmentDetailsList").empty();
        var ListHtml = '';
        ListHtml += '<table id="example" class="display nowrap cell-border" style="width:100%"><thead><tr>';
        /*            ListHtml += '<table id="example" class="display" style="width:100%"><thead><tr>';*/
        ListHtml += '<th scope="col">Name</th>';
        ListHtml += '<th scope="col">Print Name</th>';
        ListHtml += '<th scope="col">Status</th>';
        ListHtml += '<th scope="col">Action</th>';
        ListHtml += '</tr></thead> ';
        ListHtml += '<tbody>';
        if (response.masterDetailsList.length > 0) {
            $.each(response.masterDetailsList, function () {
                ListHtml += '<tr><td style="font-size: 11px">' + this.name + '</td>'
                ListHtml += '<td style="font-size: 11px">' + this.printName + '</td>'
                ListHtml += '<td>' + this.statusName + '</td><td><a href="#" class="class="fa fa-pencil"" onclick="MaintaiTestHeadOperation(' + this.rowId + ',\'' + Edit + '\');"> Edit</a> | <a href="#" class="class="fa fa-trash" onclick="MaintaiTestHeadOperation(' + this.rowId + ',\'' + Delete + '\');"> Delete</a></td>';
                ListHtml += '</tr > ';

            });
            ListHtml += '</tbody> </table>';
        }
        else {
            ListHtml += '<tr><td colspan="7"> Record Not Found ...</td></tr>';
        }
        ListHtml += '</tbody>';
        ListHtml += '</table>';
        $("#tblDepartmentDetailsList").html(ListHtml);
        //SetDataTable();
        if (value == "I" || value == "U" || value == "D") {
            ClearTestHeadField();
        }
        EnabledDisabled(value);
    });
}
function ClearTestHeadField() {
    $("#RowId").val("");
    $("#txtName").val("");
    $("#txtPrintName").val("");
    $("#dpdStatus").prop('selectedIndex', 1);
}
function datatable() {
    $('#exampleDTC').dataTable({
        bAutoWidth: true,
        sPaginationType: 'full_numbers',
        paging: false,
        bFilter: false,
        bInfo: false
    });
}