var app = angular.module('tlieta', ["kendo.directives"]);
function contactcontroller($scope) {

    $scope.contact = { ContactId: 0, ContactName: "", Address: "", Mobile: "", Email: "", Company: "", Designation: "", UpdatedOn: new Date()
    }

    $scope.contacts = new kendo.data.DataSource({
        transport: {
            read: "/Contact/Read"
        },
        pageSize: 10
    });

    $scope.savecontact = function (contact) {
        $.ajax({
            url: "/Contact/Save",
            async: false,
            type: "POST",
            data: JSON.stringify(contact),
            dataType: "json",
            contentType: "application/json; charset=utf-8",
            success: function (e) {
                RefreshGrid();
                $scope.contact = {
                    ContactId: 0, ContactName: "", Address: "", Mobile: "", Email: "", Company: "", Designation: "", UpdatedOn: new Date()
                }
            },
            error: function (e) {
                alert("Record could not be saved");
            }
        });
    }
}
