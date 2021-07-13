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
            var box = bootbox.alert(response.messageText);
            box.find('.modal-body').removeClass(".modal-content").addClass(".modal-content alert-danger");
        }
        else if (response.messageId == 3) {
            var box = bootbox.alert(response.messageText);
            box.find('.modal-body').removeClass(".modal-content").addClass(".modal-content alert-success");
        }
        else {
            $("#tblTestList").empty();
            var ListHtml = '';
            ListHtml += ' <div class="widget widget-simple widget-table">';
            ListHtml += '<table id="tblTestList" class="table table-striped table-content table-condensed boo-table table-hover bg-green-light">';
            ListHtml += '<caption class="caption-m"><span>Test List</span></caption>';
            ListHtml += '<thead><tr>';
            ListHtml += '<th scope="col">Test Name<span class="column-sorter"></span></th>';
            ListHtml += '<th scope="col">TestRate<span class="column-sorter"></span></th>';
            ListHtml += '<th scope="col">Action<span class="column-sorter"></span></th>';
            ListHtml += '</tr></thead> ';
            ListHtml += '<tbody>';
            if (response.testList.length > 0) {
                $.each(response.testList, function () {
                    ListHtml += '<td>' + this.testName + '</td>';
                    ListHtml += '<td>' + this.testRate + '</td>';
                    ListHtml += '<td><a class="btn btn-green btn-mini no-wrap" title="Add to Profile" data-toggle="tooltip" onclick="ProfileOperations(' + this.rowId + ',\'' + Insert + '\');"><i class="fa fa-plus"></i>Add To Profile</a></td>';
                    ListHtml += '</tr > ';
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
function DeleteProfileOperations(id, val) {
    bootbox.confirm("Do you want to delete this test from profile.?", function (result) {
        if (result) {
            ProfileOperations(id, val);
        }
    });
}
function ProfileOperations(Id, value) {
    var Delete = "D";
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
            var box = bootbox.alert(response.messageText);
            box.find('.modal-body').removeClass(".modal-content").addClass(".modal-content alert-danger");
        }
        else if (response.messageId == 2) {
            var box = bootbox.alert(response.messageText);
            box.find('.modal-body').removeClass(".modal-content").addClass(".modal-content alert-success");
        }
        else {
            $("#tblProfileDetailList").empty();
            var ListHtml = '';
            ListHtml += ' <div class="widget widget-simple widget-table">';
            ListHtml += '<table id="tblProfileTest" class="table table-striped table-content table-condensed boo-table table-hover bg-green-light">';
            ListHtml += '<caption class="caption-m"><span>Profile Test List</span></caption>';
            ListHtml += '<th scope="col">Profile Name<span class="column-sorter"></span></th>';
            ListHtml += '<th scope="col">Test Name<span class="column-sorter"></span></th>';
            ListHtml += '<th scope="col">Action<span class="column-sorter"></span></th>';
            ListHtml += '</tr></thead> ';
            ListHtml += '<tbody>';
            if (response.testList.length > 0) {
                $.each(response.testList, function () {
                    ListHtml += '<td>' + this.profileName + '</td>';
                    ListHtml += '<td>' + this.testName + '</td>';
                    ListHtml += '<td><a  class="btn btn-blue btn-mini no-wrap" title="Delete From Profile" data-toggle="tooltip" onclick="DeleteProfileOperations(' + this.rowId + ',\'' + Delete + '\');"><i class="fa fa-trash"></i> Delete from Profile</a></td>';
                    ListHtml += '</tr>';
                });
            }
            else {
                ListHtml += '<tr><td colspan="3"> Record Not Found ...</td></tr>';
            }
            ListHtml += '</tbody>';
            ListHtml += '</table>';
            ListHtml += '</div>';
            $("#tblProfileDetailList").html(ListHtml);
        }
    });
}
