var app = angular.module('tlieta', ['kendo.directives']);
function testcontroller($scope, $http) {

    $scope.loadContacts = function () {
        var httpRequest = $http({
            method: 'POST',
            url: '/Contact/Load/'
        }).success(function (data, status) {
            $scope.contacts = data;
        });

    };
    $scope.loadContacts();

    $scope.buttontext = "Add Contact";

    $scope.contact = { ContactId: 0, ContactName: "", Address: "", Mobile: "", Email: "", Company: "", Designation: "", UpdatedOn: new Date() };

    $scope.refreshview = function () {
        $scope.contact = { ContactId: 0, ContactName: "", Address: "", Mobile: "", Email: "", Company: "", Designation: "", UpdatedOn: new Date()};
        $scope.buttontext = "Add Contact";
        $scope.loadContacts();
    }

    $scope.savecontact = function (contact) {
        $.ajax({
            url: "/Contact/Save",
            async: false,
            type: "POST",
            data: JSON.stringify(contact),
            dataType: "json",
            contentType: "application/json; charset=utf-8",
            success: function (e) {
                $scope.refreshview();
            },
            error: function (e) {
                alert("Record could not be saved");
            }
        });
    }

    $scope.deletecontact = function (id) {
        var retVal = confirm('Are you sure you want to delete the contact?');
        if (retVal) {
            var url = '/Contact/Delete?id=' + id;
            $.ajax({
                url: url,
                type: 'POST',
                datatype: 'json',
                success: function (e) {
                    $scope.refreshview();
                },
                error: function (error) {
                    alert("Record could not be deleted");
                }
            });
        }
    }
}