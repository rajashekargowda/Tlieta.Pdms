var app = angular.module('tlieta', []);

function patientaddcontroller($scope) {
    $scope.patient = {
        PatientId: 0, FirstName: "", LastName: "", DOB: new Date(), Gender: "Male", Address: "", Mobile: "", Email: "", HomePhone: "", CreatedOn: new Date(), UpdatedOn: new Date()
    }

    $scope.savepatient = function (patient) {
        $.ajax({
            url: "/Patient/Save",
            async: false,
            type: "POST",
            data: JSON.stringify(patient),
            dataType: "json",
            contentType: "application/json; charset=utf-8",
            success: function (patient) {
                location.href = '/Patient/Info/' + patient.PatientId;
            },
            error: function (e) {
                alert("Record could not be saved");
            }
        });
    }

    $scope.refreshpatient = function () {
        $scope.patient = {
            PatientId: 0, FirstName: "", LastName: "", DOB: new Date(), Gender: "Male", Address: "", Mobile: "", Email: "", HomePhone: "", CreatedOn: new Date(), UpdatedOn: new Date()
        }
    }
}


function patientinfocontroller($scope) {

    $scope.patientid = getId();
    alert(getId() + "main");
    alert($scope.patientid);
    
    $scope.patient = {
        PatientId: 0, FirstName: "Sachin", LastName: "", DOB: new Date(), Gender: "Male", Address: "", Mobile: "", Email: "", HomePhone: "", CreatedOn: new Date(), UpdatedOn: new Date()
    }

    //$scope.loadpatient = function () {
    //    alert(pId + "function");
    //    alert($scope.patientid);

    //    $.ajax({
    //        url: "/Patient/Load",
    //        async: false,
    //        type: "POST",
    //        data: $scope.patientid,
    //        contentType: "application/json; charset=utf-8",
    //        success: function (data) {
    //            $scope.patient = data;
    //        },
    //        error: function (e) {
    //            alert("Record could not be retrieved");
    //        }
    //    });
    //}
    //$scope.loadpatient();

    $scope.refreshpatient = function () {
        $scope.patient = {
            PatientId: 0, FirstName: "", LastName: "", DOB: new Date(), Gender: "Male", Address: "", Mobile: "", Email: "", HomePhone: "", CreatedOn: new Date(), UpdatedOn: new Date()
        }
    }
}

function InitMyScript(id) {
    //var pId = id;
    //var scope = angular.element("#PatientId").scope();
    //scope.$apply(function () {
    //    $scope.patientid = id;
    //    //scope.loadpatient(id);
    //});
    //return false;
}