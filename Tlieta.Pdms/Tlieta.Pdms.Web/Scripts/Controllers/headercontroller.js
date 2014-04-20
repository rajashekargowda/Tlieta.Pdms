var app = angular.module('tlieta', []);
function headercontroller($scope) {
    $scope.home = function () {
        location.href = '/Home/Dashboard/';
    };

    $scope.changepassword = function () {
        location.href = '/Home/ChangePassword/';
    };

    $scope.logout = function () {
        location.href = '/Home/Logout/';
    };
}