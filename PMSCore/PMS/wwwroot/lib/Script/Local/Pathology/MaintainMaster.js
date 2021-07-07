
function DeleteMaintainMasterOperation(id,val) {
    bootbox.confirm("Do you want to delete this recored.?",function (result) {
            if (result) {
                MaintainMasterOperation(id, val); 
            }
    });
}
function MaintainMasterOperation(Id, value) {
    debugger;
    //var token = $('input[name="__RequestVerificationToken"]').val();
    //var headers = { '__RequestVerificationToken': token };
    var Edit = "E";
    var Delete = "D";
    var MID = $("#MID").val();
    var DeleteStatus = false;
    ColumnsAdjustment(MID);
    if (value == "D" || value == "E") {
        $("#RowId").val(Id);
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
                var box = bootbox.alert(response.messageText);
                box.find('.modal-body').removeClass(".modal-content").addClass(".modal-content alert-danger");
            }
            else if (response.messageId == 2) {
                var box = bootbox.alert(response.messageText);
                box.find('.modal-body').removeClass(".modal-content").addClass(".modal-content alert-success");
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
                    ListHtml += '<tr><td>' + this.name + '</td>'
                    ListHtml += '<td>' + this.printName + '</td>'
                    if (MID == 7) {
                        ListHtml += '<td> ' + this.rate + '</td >'
                    }
                    ListHtml += '<td>' + this.statusName + '</td><td>' + this.remarks + '</td><td><a title="Edit" data-toggle="tooltip" onclick="MaintainMasterOperation(' + this.rowId + ',\'' + Edit + '\');"><i class="fa fa-pencil"></i></a> | <a title="Delete" data-toggle="tooltip" onclick="DeleteMaintainMasterOperation(' + this.rowId + ',\'' + Delete + '\');"><i class="fa fa-trash"></i></a></td>';
                    ListHtml += '</tr > ';
                });
            }
            else {
                ListHtml += '<tr><td colspan="4"> Record Not Found ...</td></tr>';
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
function DeleteMaintainTestHeadOperation(id, val) {
    bootbox.confirm("Do you want to delete this recored.?", function (result) {
        if (result) {
            MaintainTestHeadOperation(id, val);
        }
    });
}
function MaintainTestHeadOperation(Id, value) {
    //var token = $('input[name="__RequestVerificationToken"]').val();
    //var headers = { '__RequestVerificationToken': token };
    var Edit = "E";
    var Delete = "D";
    var DepartmentId = $("#DepartmentId").val();
    if (value == "D" || value == "E") {
        $("#RowId").val(Id);
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
            var box = bootbox.alert(response.messageText);
            box.find('.modal-body').removeClass(".modal-content").addClass(".modal-content alert-danger");
        }
        else if (response.messageId == 2) {
            var box = bootbox.alert(response.messageText);
            box.find('.modal-body').removeClass(".modal-content").addClass(".modal-content alert-success");
        }
        if (value == "E") {
            $("#RowId").val(response.rowId);
            $("#txtName").val(response.name);
            $("#txtPrintName").val(response.printName);
            $("#dpdStatus").val(response.status);
        }
        $("#tblDepartmentDetailsList").empty();
        var ListHtml = '';
        ListHtml += ' <div class="widget widget-simple widget-table">';
        ListHtml += '<table id="exampleDTC" class="table table-striped table-content table-condensed boo-table table-hover bg-green-light">';
        ListHtml += '<caption class="caption-m"><span>Head List</span></caption>';
        ListHtml += '<thead><tr><th scope="col">Name<span class="column-sorter"></span></th>';
        ListHtml += '<th scope="col">Print Name<span class="column-sorter"></span></th>';
        ListHtml += '<th scope="col">Status<span class="column-sorter"></span></th>';
        ListHtml += '<th scope="col">Action<span class="column-sorter"></span></th>';
        ListHtml += '</tr></thead> ';
        ListHtml += '<tbody>';
        if (response.masterDetailsList.length > 0) {
            $.each(response.masterDetailsList, function () {
                ListHtml += '<tr><td>' + this.name + '</td>'
                ListHtml += '<td>' + this.printName + '</td>'
                ListHtml += '<td>' + this.statusName + '</td><td>' + this.remarks + '</td><td><a title="Edit" data-toggle="tooltip" onclick="MaintainTestHeadOperation(' + this.rowId + ',\'' + Edit + '\');"><i class="fa fa-pencil"></i></a> | <a title="Delete" data-toggle="tooltip" onclick="DeleteMaintainTestHeadOperation(' + this.rowId + ',\'' + Delete + '\');"><i class="fa fa-trash"></i></a></td>';
                ListHtml += '</tr> ';

            });
        }
        else {
            ListHtml += '<tr><td colspan="5"> Record Not Found ...</td></tr>';
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