var app = angular.module('tlieta', ['kendo.directives']);
function patientcontroller($scope) {
    $scope.patient = {
        PatientId: 0, FirstName: "", LastName: "", DOB: new Date(), Gender: "Male", Address: "", Mobile: "", Email: "", HomePhone: "", CreatedOn: new Date(), UpdatedOn: new Date()
    }

    $scope.products = [
        { id: 1, name: 'Tennis Balls', department: 'Sports', lastShipment: '10/01/2013' },
        { id: 2, name: 'Basket Balls', department: 'Sports', lastShipment: '10/02/2013' },
        { id: 3, name: 'Oil', department: 'Auto', lastShipment: '10/01/2013' },
        { id: 4, name: 'Filters', department: 'Auto', lastShipment: '10/01/2013' },
        { id: 5, name: 'Dresser', department: 'Home Furnishings', lastShipment: '10/01/2013' }
    ];
}

$(function () {
    $('.footable').footable();
});