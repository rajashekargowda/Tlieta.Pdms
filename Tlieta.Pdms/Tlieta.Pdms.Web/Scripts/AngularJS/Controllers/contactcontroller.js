var app = angular.module('tlieta', []);
function contactcontroller($scope) {
    $scope.savecontact = function (contact) {
        alert(contact.ContactName);
        alert(contact.ContactId);
        alert('Saved');
    };
}