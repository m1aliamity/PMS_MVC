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
    var Insert = "I";
    model = {
        RowId: $("#RowId").val(),
        DepartmentId: $("#DepartmentId").val(),
        TestHeadId: $("#TestHeadId").val(),
        Action: value,
    };
    $.ajax({
        url: "../ProfileMaster/GetTest",
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
            ListHtml += '<table id="example" class="display nowrap cell-border" style="width:100%"><thead><tr>';
            ListHtml += '<th scope="col">Test Name</th>';
            ListHtml += '<th scope="col">TestRate</th>';
            ListHtml += '<th scope="col">Action</th>';
            ListHtml += '</tr></thead> ';
            ListHtml += '<tbody>';
            if (response.testList.length > 0) {
                $.each(response.testList, function () {
                    ListHtml += '<td>' + this.testName + '</td>';
                    ListHtml += '<td>' + this.testRate + '</td><td>';
                    ListHtml += '<a href="#" class="class=" fa fa-trash" onclick="ProfileOperations(' + this.rowId + ', \'' + Insert + '\');"> Send To Profile </a></td>';
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
function ProfileOperations(Id,value) {
    var Delete = "D";
    if (value == "D") {
        status = confirm('Are you sure? want to delete');
        if (!status) {
            return false;
        }
    }
    model = {
        RowId: Id,
        ProfileId: $("#ProfileId").val(),
        TestId: Id,
        Action: value,
    };
    $.ajax({
        url: "../ProfileMaster/ProfileOperations",
        type: "POST",
        cache: false,
        async: true,
        data: model,

    }).done(function (response) {
        if (response.messageId == 1) {
            alert(response.messageText);
        }
        else {
            $("#tblProfileDetailList").empty();
            var ListHtml = '';
            ListHtml += '<table id="example" class="display nowrap cell-border" style="width:100%"><thead><tr>';
            ListHtml += '<th scope="col">Profile Name</th>';
            ListHtml += '<th scope="col">Test Name</th>';
            ListHtml += '<th scope="col">Action</th>';
            ListHtml += '</tr></thead> ';
            ListHtml += '<tbody>';
            if (response.testList.length > 0) {
                $.each(response.testList, function () {
                    ListHtml += '<td>' + this.profileName + '</td>';
                    ListHtml += '<td>' + this.testName + '</td><td>';
                    ListHtml += '<a href="#" class="class=" fa fa-trash" onclick="ProfileOperations(' + this.rowId + ', \'' + Delete + '\');"> Delete</a></td>';
                    ListHtml += '</tr > ';
                });
                ListHtml += '</tbody> </table>';
            }
            else {
                ListHtml += '<tr><td colspan="7"> Record Not Found ...</td></tr>';
            }
            ListHtml += '</tbody>';
            ListHtml += '</table>';
            $("#tblProfileDetailList").html(ListHtml);
        }
    });
}
