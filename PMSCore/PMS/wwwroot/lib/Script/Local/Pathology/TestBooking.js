function GetTestHeadMaster() {
    var deptId = 0;
    deptId = $("#DepartmentId").val();
    model = {
        DepartmentId: deptId,
    };
    $.ajax({
        url: "../ProfileMaster/GetTestHeadMaster",
        type: "POST",
        cache: false,
        async: true,
        data: model,
        success: function (Response) {

            $("#TestHeadId").empty();
            $("#TestHeadId").append($("<option  value='0' selected>--Select--</option>"));
            $.each(Response.testHeadMasterList, function () {
                $("#TestHeadId").append($("<option></option>").val(this.value).html(this.text));

            });
        }
    })
}
function GetTestDetails(value) {
    var Insert = 1;
    var Id = 0;
    model = {
        RowId: $("#RowId").val(),
        DepartmentId: $("#DepartmentId").val(),
        HeadId: $("#TestHeadId").val(),
        Action: value,
    };
    $.ajax({
        url: "../TestBooking/GetTest",
        type: "POST",
        cache: false,
        async: true,
        data: model,

    }).done(function (response) {
        if (response.messageId == 1) {
            alert(response.messageText);
        }
        else {
            $("#tblTestList").empty();
            var ListHtml = '';
            ListHtml += '<table id="example12" class="display nowrap cell-border" style="width:100%"><thead><tr>';
            ListHtml += '<th scope="col">Test Name</th>';
            ListHtml += '<th scope="col">TestRate</th>';
            ListHtml += '<th scope="col">Action</th>';
            ListHtml += '</tr></thead> ';
            ListHtml += '<tbody>';
            if (response.testList.length > 0) {
                $.each(response.testList, function () {
                    ListHtml += '<td>' + this.testName + '</td>';
                    ListHtml += '<td>' + this.rate + '</td><td>';
                    ListHtml += '<a href="#" onclick="AddData(' + Id + ', \'' + this.rowId + '\', \'' + this.headId + '\', \'' + Id + '\', \'' + Insert + '\');"> Add </a></td>';
                    ListHtml += '</tr > ';
                });
                ListHtml += '</tbody> </table>';
            }
            else {
                ListHtml += '<tr><td colspan="7"> Record Not Found ...</td></tr>';
            }
            ListHtml += '</tbody>';
            ListHtml += '</table>';
            $("#tblTestList").html(ListHtml);
        }
    });
}
function AddData(id, testId, headId, profileId, action) {
    var Delete = 2;
    var val = 0;
    debugger;
    model = {
        RowId: id,
        TestId: testId,
        HeadId: headId,
        ProfileId: profileId,
        Rate: 0,
        Action: action,
    };
    $.ajax({
        url: "../TestBooking/AddData",
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
            ListHtml += '<table id="example12" class="display nowrap cell-border" style="width:100%"><thead><tr>';
            ListHtml += '<th scope="col">Test Name</th>';
            ListHtml += '<th scope="col">TestRate</th>';
            ListHtml += '<th scope="col">Action</th>';
            ListHtml += '</tr></thead> ';
            ListHtml += '<tbody>';
            if (response.testList.length > 0) {
                $.each(response.testList, function () {
                    ListHtml += '<td>' + this.testName + '</td>';
                    ListHtml += '<td>' + this.rate + '</td><td>';
                    ListHtml += '<a href="#" onclick="AddData(' + this.rowId + ',\'' + val + '\',\'' + val + '\',\'' + val + '\', \'' + Delete + '\');"> Delete </a></td>';
                    ListHtml += '</tr > ';
                });
                ListHtml += '</tbody> </table>';
            }
            else {
                ListHtml += '<tr><td colspan="7"> Record Not Added ...</td></tr>';
            }
            ListHtml += '</tbody>';
            ListHtml += '</table>';
            $("#tblTestBookingList").html(ListHtml);
            $("#txtTotalAmount").val(response.totalAmount);
            $("#txtPaidAmount").val(response.totalAmount);
            $("#txtDiscountAmount").val("0");
            $("#txtBalanceAmount").val("0");
            CalculateDiscount("D");
        }
    });
}
function CalculateDiscount(val) {

    var TotalAmount = $("#txtTotalAmount").val();
    var DiscountAmount = $("#txtDiscountAmount").val();
    if (parseFloat(DiscountAmount) > parseFloat(TotalAmount)) {
        alert("Discount Amount Can't be greater than Total Amount.");
        $("#txtDiscountAmount").val("0");
    }
    var DiscountAmount1 = $("#txtDiscountAmount").val();
    if (val != 'P') {
        $("#txtPaidAmount").val((parseFloat(TotalAmount) - parseFloat(DiscountAmount1)));
    }
    var PaidAmount = $("#txtPaidAmount").val();
    var balanceAmount = (parseFloat(TotalAmount) - parseFloat(DiscountAmount1) - parseFloat(PaidAmount));
    $("#txtBalanceAmount").val(balanceAmount);
}
function CheckYear() {
    var Month = $("#txtAgeMonth").val();
    var Day = $("#txtAgeDay").val();
    var Year = $("#txtAgeYear").val();
    if (parseInt(Month) > 11) {
        alert("Please Enter Valid Month Less than 12.");
        $("#txtAgeMonth").val("0");
    }
    if (parseInt(Day) > 29) {
        alert("Please Enter Valid Day Less than 30.");
        $("#txtAgeDay").val("0");
    }
    if (parseInt(Year) == 0) {
        $("#txtAgeYear").val("0");
    }
}
function TestBookingOperations(Id, Val) {
    var Edit = "E";
    var Delete = "D";
    model = {
        RowId: $("#RowId").val(),
        PatientType:2,
        BalanceAmount: $("TitleId").val(),
        TitleId: $("#TitleId").val(),
        PatientName: $("#txtPatientName").val(),
        GendarId: $("#GendarId").val(),
        PatientAge: $("TitleId").val(),
        MobileNo: $("#txtMobileNo").val(),
        Email: $("#txtEmailId").val(),
        Address: $("#txtAddress").val(),
        ReferredById: $("#ReferredById").val(),
        SampleById: $("#SampleById").val(),
        SampleTypeId: $("#SampleTypeId").val(),
        TotalAmount: $("#txtTotalAmount").val(),
        DiscountAmount: $("#txtDiscountAmount").val(),
        PaidAmount: $("#txtPaidAmount").val(),
        BalanceAmount: $("#txtBalanceAmount").val(),
        Action: Val,
    };
    $.ajax({
        url: "../TestBooking/TestBookingOperations",
        type: "POST",
        cache: false,
        async: true,
        data: model,

    }).done(function (response) {
        if (response.messageId == 1) {
            alert(response.messageText);
        }
    });
}
