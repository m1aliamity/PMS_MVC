function SearchBookingData(Id,Val) {
    var Delete = 4;
    var Print = 3;
    var FillResults = 2;
   // var val = 0;
    debugger;
    model = {
        RowId: Id,//$("#RowId").val(),
        FromDate: $("#txtFromDate").val(),
        ToDate: $("#txtToDate").val(),
        Action: Val,
    };
    $.ajax({
        url: "../FillTestResults/SearchBookingData",
        type: "POST",
        cache: false,
        async: true,
        data: model,

    }).done(function (response) {
        if (response.messageId == 1) {
            alert(response.messageText);
        }
        else {
            $("#tblTestBookingList").empty();
            var ListHtml = '';
            ListHtml += '<div class="widget widget-simple widget-table">';
            ListHtml += '<table id="TestMasterList" class="table table-striped table-content table-condensed boo-table table-hover bg-green-light">';
            ListHtml += '<caption class="caption-m"><span>Booking List</span></caption>';
            ListHtml += '<thead><tr>';
            ListHtml += '<th scope="col">Name<span class="column-sorter"></span></th>';
            ListHtml += '<th scope="col">Age<span class="column-sorter"></span></th>';
            ListHtml += '<th scope="col">Gender<span class="column-sorter"></span></th>';
            ListHtml += '<th scope="col">Sample Type<span class="column-sorter"></span></th>';
            ListHtml += '<th scope="col">Address<span class="column-sorter"></span></th>';
            ListHtml += '<th scope="col">Booking Date<span class="column-sorter"></span></th>';
            ListHtml += '<th scope="col">Action<span class="column-sorter"></span></th>';
            ListHtml += '</tr></thead> ';
            ListHtml += '<tbody>';
            if (response.testList.length > 0) {
                $.each(response.testList, function () {
                    ListHtml += '<tr><td>' + this.patientName + '</td>';
                    ListHtml += '<td>' + this.patientAge + '</td>';
                    ListHtml += '<td>' + this.genderName + '</td>';
                    ListHtml += '<td>' + this.sampleTypeName + '</td>';
                    ListHtml += '<td>' + this.address + '</td>';
                    ListHtml += '<td>' + this.bookingDate + '</td>';
                    ListHtml += '<td>';
                    ListHtml += '<a title="Fill Test Result" data-toggle="tooltip" class="btn btn-yellow btn-mini no-wrap" onclick="DisplayTestDetails(' + this.rowId + ',\'' + FillResults + '\');"><i class="fa fa-edit"></i> Fill Result</a>';
                    ListHtml += '<a title="Print Test Report" data-toggle="tooltip" class="btn btn-green btn-mini no-wrap" onclick="AddData(' + this.rowId + ',\'' + Print + '\');"><i class="fa fa-print"></i> Print Report</a>';
                    ListHtml += '<a title="Delete Test Booking" data-toggle="tooltip" class="btn btn-blue btn-mini no-wrap" onclick="AddData(' + this.rowId + ',\'' + Delete + '\');"><i class="fa fa-trash"></i> Delete</a>';
                    ListHtml += '</td>';
                    ListHtml += '</tr > ';
                });
            }
            else {
                ListHtml += '<tr><td colspan="7"> Record Not Added ...</td></tr>';
            }
            ListHtml += '</tbody>';
            ListHtml += '</table>';
            ListHtml += '</div>';
            $("#tblTestBookingList").html(ListHtml);
        }
    });
}
function DisplayTestDetails(Id,Val) {
    model = {
        RowId: Id,//$("#RowId").val(),
        FromDate: $("#txtFromDate").val(),
        ToDate: $("#txtToDate").val(),
        Action: Val,
    };
    $.ajax({
        url: "../FillTestResults/GetTestDetails",
        type: "POST",
        cache: false,
        async: true,
        data: model,
        success: function (response) {
            if (Val = 2) {
                $("#FillTestResult").html(response);
                $("#FillTestResult").modal("show");
            }
            else if (Val = 3) {
                $("#advanceDetails").html(response);
                $("#advanceDetails").modal("show");
            }
        }
    });
}
function SaveTestResult(Id, val, results, status, PrintTest, PrintInterpretations) {
    debugger;
    var Interpretations = "";
    var result = "";
    if (val == 1) {
        result = $("#TestResult").val();
        Interpretations = CKEDITOR.instances.Interpretation.getData();
    }
    else {
        result = results
    }
    model = {
        RowId: Id,
        ResultStatus: status,
        PrintResult: PrintTest,
        PrintInterpretation: PrintInterpretations,
        FromRange: $("#FromRange").val(),
        ToRange: $("#ToRange").val(),
        TestResult: result ,
        Note: $("#Note").val(),
        Interpretation: Interpretations,
        Action: val,
    };
    $.ajax({
        url: "../FillTestResults/SaveTestResult",
        type: "POST",
        cache: false,
        async: true,
        data: model,
        success: function (response) {
            alert("Result saved successfully.");
        }
    });
}