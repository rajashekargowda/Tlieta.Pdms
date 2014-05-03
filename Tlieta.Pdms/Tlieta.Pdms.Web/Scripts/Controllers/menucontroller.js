var app = angular.module('tlieta', []);
function menucontroller($scope) {
    $scope.redirect = function (menu) {
        if (menu == 'contacts')
            location.href = '/Contact/Manage/';
        if (menu == 'appointments')
            location.href = '/Appointment/Manage/';
        else if (menu == 'users')
            location.href = '/Employee/Manage/';
        else if (menu == 'drugs')
            location.href = '/Drug/Manage/';
    };
}