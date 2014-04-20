var app = angular.module('tlieta', []);
function menucontroller($scope) {
    $scope.redirect = function (menu) {
        if (menu == 'contacts')
            location.href = '/Contact/Manage/';
        else if (menu == 'users')
            location.href = '/Employee/Manage/';
    };
}