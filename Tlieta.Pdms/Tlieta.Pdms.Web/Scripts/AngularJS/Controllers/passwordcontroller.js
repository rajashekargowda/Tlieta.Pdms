var app = angular.module('tlieta', ['PasswordValidation']);

function passwordcontroller($scope) {
    $scope.savepassword = function (password) {
        alert(password.newpassword);
        alert('Saved');
    };
}

angular.module('PasswordValidation', []).directive('validPasswordC', function () {
    return {
        require: 'ngModel',
        link: function (scope, elm, attrs, ctrl) {
            ctrl.$parsers.unshift(function (viewValue, $scope) {
                var noMatch = viewValue != scope.formChangePassword.newpassword.$viewValue
                ctrl.$setValidity('noMatch', !noMatch)
            })
        }
    }
})