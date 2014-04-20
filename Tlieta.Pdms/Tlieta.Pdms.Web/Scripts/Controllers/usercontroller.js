var app = angular.module('tlieta', []);
function usercontroller($scope) {

    $scope.roles = [
    { RoleName: 'Admin', RoleId: '1' },
    { RoleName: 'Doctor', RoleId: '2' },
    { RoleName: 'Nurse', RoleId: '3' },
    { RoleName: 'Pharmacist', RoleId: '4' },
    { RoleName: 'Receptionist', RoleId: '5' }
    ];
    $scope.role = $scope.roles[0];

    $scope.buttontext = "Add User";

    $scope.user = { EmployeeId: 0, EmployeeName: "", RoleId: 0, EmailId: "", Phone: "", UserId: "", Password: "", CreatedOn: new Date() }

    $scope.refreshuser = function () {
        $scope.user = { EmployeeId: 0, EmployeeName: "", RoleId: 0, EmailId: "", Phone: "", UserId: "", Password: "", CreatedOn: new Date() }
        $scope.buttontext = "Add User";
        RefreshListView();
    }

    $scope.saveuser = function (user) {
        $.ajax({
            url: "/Employee/Save",
            async: false,
            type: "POST",
            data: JSON.stringify(user),
            dataType: "json",
            contentType: "application/json; charset=utf-8",
            success: function (e) {
                RefreshGrid();
                RefreshListView();
                $scope.refreshuser();
            },
            error: function (e) {
                alert("Record could not be saved");
            }
        });
    }

    $scope.deleteuser = function (id) {
        var retVal = confirm('Are you sure you want to delete the user?');
        if (retVal) {
            var url = '/Employee/Delete?id=' + id;
            $.ajax({
                url: url,
                type: 'POST',
                datatype: 'json',
                success: function (e) {
                    RefreshGrid();
                    $scope.refreshuser();
                },
                error: function (error) {
                    alert("Record could not be deleted");
                    return false;
                }
            });
        }
    }
}


function Edit(e) {
    var dataItem = this.dataItem($(e.target).closest("tr"));
    var scope = angular.element("#EmployeeName").scope();
    scope.$apply(function () {
        scope.user = dataItem;
        scope.buttontext = "Update User";

        var listView = $("#RoleList").data("kendoListView");
        listView.select(listView.element.children()[dataItem.RoleId - 1]);
    });
    return false;
}

function Delete(e) {
    var dataItem = this.dataItem($(e.target).closest("tr"));
    angular.element("#EmployeeName").scope().deleteuser(dataItem.EmployeeId);
    return false;
}

function RefreshGrid() {
    var grid = $("#UserGrid").data("kendoGrid");
    grid.dataSource.read();
}

function RefreshListView() {
    var listView = $("#RoleList").data("kendoListView");
    listView.clearSelection();
}

function onRoleChange(e) {

    var index = this.select().index();
    var dataItem = this.dataSource.view()[index];
    
    var scope = angular.element("#EmployeeName").scope();
    scope.$apply(function () {
        if (dataItem) {
            scope.user.RoleId = dataItem.RoleId;
        }
        else
            scope.user.RoleId = 0;
    });
    return false;
}
