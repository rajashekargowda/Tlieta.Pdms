var app = angular.module('tlieta', ['kendo.directives']);
function contactcontroller($scope) {

    $scope.contact = { ContactId: 0, ContactName: "", Address: "", Mobile: "", Email: "", Company: "", Designation: "", UpdatedOn: new Date()
    }

    $scope.refreshcontact = function () {
        $scope.contact = {
            ContactId: 0, ContactName: "", Address: "", Mobile: "", Email: "", Company: "", Designation: "", UpdatedOn: new Date()
        }
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
                RefreshGrid();
                $scope.refreshcontact();
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
                    RefreshGrid();
                    $scope.refreshcontact();
                },
                error: function (error) {
                    alert("Record could not be deleted");
                }
            });
        }
    }
}
