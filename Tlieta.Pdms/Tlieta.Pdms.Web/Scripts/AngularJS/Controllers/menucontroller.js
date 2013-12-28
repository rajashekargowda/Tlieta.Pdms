var app = angular.module('tlieta', []);
function menucontroller($scope) {
    $scope.redirect = function (menu) {
        if (menu == 'contact')
            location.href = '/Contact/PdmsView/';
    };
}