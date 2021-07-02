function SearchBookingData(Id,Val) {
    var Delete = 4;
    var Print = 3;
    var FillResults = 2;
    var val = 0;
    debugger;
    model = {
        RowId: Id,//$("#RowId").val(),
        //FromDate: $("#txtFromDate").val(),
        //ToDate: $("#txtToDate").val(),
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
            $("#tblTestDetailList").empty();
            var ListHtml = '';
            ListHtml += '<table id="example12" class="display nowrap cell-border" style="width:100%"><thead><tr>';
            ListHtml += '<th scope="col">Name</th>';
            ListHtml += '<th scope="col">Age</th>';
            ListHtml += '<th scope="col">Gender</th>';
            ListHtml += '<th scope="col">Sample Type</th>';
            ListHtml += '<th scope="col">Address</th>';
            ListHtml += '<th scope="col">Booking Date</th>';
            ListHtml += '<th scope="col">Action</th>';
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
                    ListHtml += '<a href="#" onclick="AddData(' + this.rowId + ',\'' + FillResults + '\');">Fill Results</a>|'
                    ListHtml += '<a href="#" onclick="AddData(' + this.rowId + ',\'' + Print + '\');">Print Report</a>|'
                    ListHtml += '<a href="#" onclick="AddData(' + this.rowId + ',\'' + Delete + '\');">Delete</a>'
                    ListHtml += '</td>';
                    ListHtml += '</tr > ';
                });
                ListHtml += '</tbody> </table>';
            }
            else {
                ListHtml += '<tr><td colspan="7"> Record Not Added ...</td></tr>';
            }
            ListHtml += '</tbody>';
            ListHtml += '</table>';
            $("#tblTestDetailList").html(ListHtml);
        }
    });
}
function SearchBookingData(Id, Val) {
    var Delete = 4;
    var Print = 3;
    var FillResults = 2;
    //var val = 0;
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
            if (Val == 1) {
                $("#tblTestDetailList").empty();
                var ListHtml = '';
                ListHtml += '<table id="example12" class="display nowrap cell-border" style="width:100%"><thead><tr>';
                ListHtml += '<th scope="col">Name</th>';
                ListHtml += '<th scope="col">Age</th>';
                ListHtml += '<th scope="col">Gender</th>';
                ListHtml += '<th scope="col">Sample Type</th>';
                ListHtml += '<th scope="col">Address</th>';
                ListHtml += '<th scope="col">Booking Date</th>';
                ListHtml += '<th scope="col">Action</th>';
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
                        ListHtml += '<a href="#" onclick="DisplayTestDetails(' + this.rowId + ',\'' + FillResults + '\');">Fill Results</a>|'
                        ListHtml += '<a href="#" onclick="AddData(' + this.rowId + ',\'' + Print + '\');">Print Report</a>|'
                        ListHtml += '<a href="#" onclick="AddData(' + this.rowId + ',\'' + Delete + '\');">Delete</a>'
                        ListHtml += '</td>';
                        ListHtml += '</tr > ';
                    });
                    ListHtml += '</tbody> </table>';
                }
                else {
                    ListHtml += '<tr><td colspan="7"> Record Not Added ...</td></tr>';
                }
                ListHtml += '</tbody>';
                ListHtml += '</table>';
                $("#tblTestDetailList").html(ListHtml);
            }
            else if (Val == 2) {
                
            }
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
                debugger;
                $("#advanceDetails").html(response);
                //$("#txtFromRange").val(response.fromRange);
                //$("#txtToRange").val(response.toRange);
                //$("#txtResult").val(response.testResult);
                //$("#txtNote").val(response.note);
                //Getdata from editor
                //Interpretations = CKEDITOR.instances.interpretation.getData()
                /*CKEDITOR.instances.interpretation.setData(response.interpretation);*/
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