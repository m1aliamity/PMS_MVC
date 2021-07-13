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
            ListHtml += '<div class="widget widget-simple widget-table">';
            ListHtml += '<table id="exampleDTC" class="table table-striped table-content table-condensed boo-table table-hover bg-green-light">';
            ListHtml += '<caption class="caption-m"><span>Test List</span></caption>';
            ListHtml += '<th scope="col">Test Name<span class="column-sorter"></span></th>';
            ListHtml += '<th scope="col">TestRate<span class="column-sorter"></span></th>';
            ListHtml += '<th scope="col">Action<span class="column-sorter"></span></th>';
            ListHtml += '</tr></thead> ';
            ListHtml += '<tbody>';
            if (response.testList.length > 0) {
                $.each(response.testList, function () {
                    ListHtml += '<td>' + this.testName + '</td>';
                    ListHtml += '<td>' + this.rate + '</td><td>';
                    ListHtml += '<a title="Add Test To Booking Detail" data-toggle="tooltip" class="btn btn-green btn-mini no-wrap" onclick="AddData(' + Id + ', \'' + this.rowId + '\', \'' + this.headId + '\', \'' + Id + '\', \'' + Insert + '\');"><i class="fa fa-plus"></i> Add</a></td>';
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
            var box = bootbox.alert(response.messageText);
            box.find('.modal-body').removeClass(".modal-content").addClass(".modal-content alert-danger");
        }
        else if (response.messageId == 2) {
            var box = bootbox.alert(response.messageText);
            box.find('.modal-body').removeClass(".modal-content").addClass(".modal-content alert-success");
            $("#tblTestBookingList").empty();
            var ListHtml = '';
            ListHtml += '<div class="widget widget-simple widget-table">';
            ListHtml += '<table id="exampleDTC" class="table table-striped table-content table-condensed boo-table table-hover bg-green-light">';
            ListHtml += '<caption class="caption-m"><span>Test Details</span></caption>';
            ListHtml += '<th scope="col">Test Name<span class="column-sorter"></span></th>';
            ListHtml += '<th scope="col">TestRate<span class="column-sorter"></span></th>';
            ListHtml += '<th scope="col">Action<span class="column-sorter"></span></th>';
            ListHtml += '</tr></thead> ';
            ListHtml += '<tbody>';
            if (response.testList.length > 0) {
                $.each(response.testList, function () {
                    ListHtml += '<td>' + this.testName + '</td>';
                    ListHtml += '<td>' + this.rate + '</td><td>';
                    ListHtml += '<a title="Delete Test From Booking Detail" data-toggle="tooltip" class="btn btn-blue btn-mini no-wrap" onclick="AddData(' + this.rowId + ',\'' + val + '\',\'' + val + '\',\'' + val + '\', \'' + Delete + '\');"><i class="fa fa-trash"></i> Delete</a></td>';
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
        PatientType:1,
        BalanceAmount: $("TitleId").val(),
        TitleId: $("#TitleId").val(),
        PatientName: $("#txtPatientName").val(),
        GenderId: $("#GenderId").val(),
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
            var box = bootbox.alert(response.messageText);
            box.find('.modal-body').removeClass(".modal-content").addClass(".modal-content alert-danger");
        }
        else if (response.messageId == 2) {
            var box = bootbox.alert(response.messageText);
            box.find('.modal-body').removeClass(".modal-content").addClass(".modal-content alert-success");
        }
    });
}
function SelectPatientType(val) {
    debugger;
    if (val == "1") {
        $("#btnNewPatient").removeClass("btn").addClass("btn btn-green active");
        $("#btnRegisteredPatient").removeClass("btn btn-green active").addClass("btn");
    }
    else if (val == "2") {
        $("#btnNewPatient").removeClass("btn btn-green active").addClass("btn");
        $("#btnRegisteredPatient").removeClass("btn").addClass("btn btn-green active");
        $.ajax({
            url: "../TestBooking/SearchPatient",
            type: "POST",
            success: function (Response) {
                $("#PatientList").html(Response);
                $("#PatientList").modal("show");
            }
        })
    }
 }
