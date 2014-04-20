var app = angular.module('tlieta', []);
function logincontroller($scope) {

    $scope.error = "";

    $scope.user = { EmployeeId: 0, EmployeeName: "", RoleId: 0, EmailId: "", Phone: "", UserId: "", Password: "", CreatedOn: new Date() }

    $scope.authenticate = function () {
        $.ajax({
            url: "/Home/Authenticate/",
            async: false,
            type: "POST",
            data: JSON.stringify($scope.user),
            dataType: "json",
            contentType: "application/json; charset=utf-8",
            success: function (data) {
                if (data.RoleId > 0) {
                    location.href = '/Home/Dashboard/';
                }
                else { alert("Error : Could not login"); }
            },
            error: function (e) {
                alert("Error : Could not login");
            }
        });
    }    
}