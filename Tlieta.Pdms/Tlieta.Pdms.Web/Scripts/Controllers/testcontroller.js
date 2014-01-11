var app = angular.module('tlieta', []);
app.directive('kendogrid', function () {
    return {
        restrict: 'E',
        replace: true,
        scope: { source: '=source', columns: '=columns' },
        template: '<div id="kendogrid"></div>',
        link: function (scope, element, attrs) {
            element.kendoGrid({
                dataSource: scope.source,
                groupable: attrs.groupable,
                sortable: attrs.sortable,
                pageable: {
                    refresh: true,
                    pageSizes: true
                },
                columns: scope.columns
            });
        }
    };
});
function testcontroller($scope, $http) {

    $scope.columns = [{ field: "ContactName", title: "ContactName" }, { field: "ContactId", title: "ContactId" }];

    //$scope.products = new kendo.data.DataSource({
    //    data: [
    //       { id: 1, name: 'Tennis Balls', department: 'Sports', lastShipment: '10/01/2013' },
    //       { id: 2, name: 'Basket Balls', department: 'Sports', lastShipment: '10/02/2013' },
    //       { id: 3, name: 'Oil', department: 'Auto', lastShipment: '10/01/2013' },
    //       { id: 4, name: 'Filters', department: 'Auto', lastShipment: '10/01/2013' },
    //       { id: 5, name: 'Dresser', department: 'Home Furnishings', lastShipment: '10/01/2013' }
    //    ],
    //    pageSize: 2
    //});

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