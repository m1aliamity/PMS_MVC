function AddTest() {
    debugger;
    $.ajax({
        url: "../TestMaster/AddTest",
        type: "POST",
        success: function (Response) {
            $("#AddTest").html(Response);
            $("#AddTest").modal("show");
        }
    })
}

function GetTestHeadMaster(val) {
    debugger;
    var deptId = 0;
    if (val == 'M') {
        deptId = $("#DepartmentId").val();
    }
    else {
        deptId = $("#Department_Id").val();
    }
    model = {
        DepartmentId: deptId,
    };
    $.ajax({
        url: "../TestMaster/GetTestHeadMaster",
        type: "POST",
        cache: false,
        async: true,
        data: model,
        success: function (Response) {
            if (val == 'M') {
                $("#TestHeadId").empty();
                $("#TestHeadId").append($("<option  value='0' selected>--Select--</option>"));
                $.each(Response.testHeadMasterList, function () {
                    $("#TestHeadId").append($("<option></option>").val(this.value).html(this.text));

                });
            }
            else {
                $("#TestHead_Id").empty();
                $("#TestHead_Id").append($("<option  value='0' selected>--Select--</option>"));
                $.each(Response.testHeadMasterList, function () {
                    $("#TestHead_Id").append($("<option></option>").val(this.value).html(this.text));

                });
            }
        }
    })
}
function DeleteTestOperations(id, val) {
    bootbox.confirm("Do you want to delete this recored.?", function (result) {
        if (result) {
            TestOperations(id, val);
        }
    });
}
function TestOperations(Id, value) {
    debugger;
    var Edit = "E";
    var Delete = "D";
    var Interpretations = "";
    if (value == "D" || value == "E" || value == "") {
        $("#RowId").val(Id);
    }
    else {
        Interpretations = CKEDITOR.instances.interpretation.getData()
    }
    if (value == "E") {
        AddTest();
    }
    //Avar ckValue = CKEDITOR.instances.interpretation.getData();
    model = {
        RowId: $("#RowId").val(),
        DepartmentId: $("#DepartmentId").val(),
        Department_Id: $("#Department_Id").val(),
        TestHead_Id: $("#TestHead_Id").val(),
        TestHeadId: $("#TestHeadId").val(),
        TestName: $("#txtTestName").val(),
        TestRate: $("#txtTestRate").val(),
        Unit: $("#txtUnit").val(),
        TestType: $("#TestType").val(),
        DefaultRange: $("#txtDefaultRange").val(),
        FromRange: $("#txtFromRange").val(),
        ToRange: $("#txtToRange").val(),
        TestUnder: $("#txtUnder").val(),
        Formula: $("#txtFormula").val(),
        Method: $("#txtMethod").val(),
        Interpretation: Interpretations,
        Action: value,
    };
    $.ajax({
        url: "../TestMaster/TestOperations",
        type: "POST",
        cache: false,
        async: true,
        data: model,

    }).done(function (response) {
        if (response.messageId == 1) {
            var box = bootbox.alert(response.messageText);
            box.find('.modal-body').removeClass(".modal-content").addClass(".modal-content alert-danger");
        }
        else if (response.messageId == 2) {
            var box = bootbox.alert(response.messageText);
            box.find('.modal-body').removeClass(".modal-content").addClass(".modal-content alert-success");
            $("#tblTestList").empty();
        }
        var ListHtml = '';
        ListHtml += '<div class="widget widget-simple widget-table">';
        ListHtml += '<table id="TestMasterList" class="table table-striped table-content table-condensed boo-table table-hover bg-green-light">';
        ListHtml += '<caption class="caption-m"><span>Test List</span></caption>';
        ListHtml += '<thead><tr>';
        ListHtml += '<th scope="col">Department<span class="column-sorter"></span></th>';
        ListHtml += '<th scope="col">Test Head<span class="column-sorter"></span></th>';
        ListHtml += '<th scope="col">Test Name<span class="column-sorter"></span></th>';
        ListHtml += '<th scope="col">TestRate<span class="column-sorter"></span></th>';
        ListHtml += '<th scope="col">Action<span class="column-sorter"></span></th>';
        ListHtml += '</tr></thead> ';
        ListHtml += '<tbody>';
        if (response.testList.length > 0) {
            $.each(response.testList, function () {
                ListHtml += '<tr><td>' + this.departmentName + '</td>';
                ListHtml += '<td>' + this.testHeadName + '</td>';
                ListHtml += '<td>' + this.testName + '</td>';
                ListHtml += '<td>' + this.testRate + '</td>';
                ListHtml += '<td><a class="btn btn-yellow btn-mini no-wrap" title="Edit" data-toggle="tooltip" onclick="TestOperations(' + this.rowId + ',\'' + Edit + '\');"><i class="fa fa-pencil"></i> Edit</a> <a class="btn btn-blue btn-mini no-wrap" title="Delete" data-toggle="tooltip" onclick="DeleteTestOperations(' + this.rowId + ',\'' + Delete + '\');"><i class="fa fa-trash"></i> Delete</a></td>';
                ListHtml += '</tr> ';

            });
        }
        else {
            ListHtml += '<tr><td colspan="7"> Record Not Found ...</td></tr>';
        }
        ListHtml += '</tbody>';
        ListHtml += '</table>';
        ListHtml += '</div>';
        $("#tblTestList").html(ListHtml);
        if (value == "E") {
            $("#RowId").val(response.rowId);
            $("#TestHead_Id").val(response.head_Id);
            $("#Department_Id").val(response.department_Id);
            $("#txtTestName").val(response.testName);
            $("#txtTestRate").val(response, testRate);
            $("#txtUnit").val(response.unit);
            $("#TestType").val(response.testType);
            $("#txtDefaultRange").val(response.defaultRange);
            $("#txtFromRange").val(response.fromRange);
            $("#txtToRange").val(response.toRange);
            $("#txtUnder").val(response.testUnder);
            $("#txtFormula").val(response.formula);
            $("#txtMethod").val(response.method);
            CKEDITOR.instances.interpretation.setData(response.interpretation);
            //$("#interpretation").val(response.interpretation);
        }
        //SetDataTable();
        if (value == "I" || value == "U" || value == "D") {
            ClearField();
        }
        EnabledDisabled(value);
    });
}
function ClearField() {
    CKEDITOR.instances.interpretation.setData('');
    $("#RowId").val("");
    $("#Department_Id").val('selectedIndex', 1);
    $("#TestHead_Id").val('selectedIndex', 1);
    $("#txtTestName").val("");
    $("#txtTestRate").val("");
    $("#txtUnit").val("");
    $("#TestType").val("");
    $("#txtDefaultRange").val("");
    $("#txtFromRange").val("");
    $("#txtToRange").val("");
    /*$("#txtUnder").val('selectedIndex', 1);*/
    $("#txtFormula").val("");
    $("#txtMethod").val("");
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


