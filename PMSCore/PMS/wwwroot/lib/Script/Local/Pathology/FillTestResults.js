function SearchBookingData(Id,Val) {
    var Delete = 2;
    var val = 0;
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
                    ListHtml += '<td>' + this.gendarName + '</td>';
                    ListHtml += '<td>' + this.sampleTypeName + '</td>';
                    ListHtml += '<td>' + this.address + '</td>';
                    ListHtml += '<td>' + this.bookingDate + '</td>';
                    ListHtml += '<td><a href="#" onclick="AddData(' + this.rowId + ',\'' + val + '\',\'' + val + '\',\'' + val + '\', \'' + Delete + '\');"> Delete </a></td>';
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