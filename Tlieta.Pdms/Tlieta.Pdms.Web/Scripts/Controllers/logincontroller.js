var app = angular.module('tlieta', []);
function logincontroller($scope) {

    $scope.error = "";

    $scope.user = { UserId: "", Password: "" }

    $scope.authenticate = function () {
        var el = new Everlive('WjpzCxGm0DgYBhrZ');
        el.Users.login(
            $scope.user.UserId, $scope.user.Password,
            function (data) {
                var userid = data.result.principal_id;
                location.href = '/Home/Dashboard?user=' + userid;
            },
            function (error) {
                alert(error.code + " : " + error.message);
            });
    }    
}