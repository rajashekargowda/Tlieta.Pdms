var app = angular.module('tlieta', []);
function appointmentcontroller($scope, $filter) {

    $scope.emptystring = "";
    $scope.errorstring = "( * ) Mandatory fields.";
    $scope.buttontext = "Add Appointment";
    $scope.errormessage = $scope.errorstring;

    $scope.appointment = {
        AppointmentId: 0, AppointmentDate: new Date(), DoctorId: 0, DoctorName: "", PatientName: "", PatientId: "", Mobile: "", Email: "", UpdatedOn: new Date()
    }

    $scope.refreshappointment = function () {
        $scope.appointment = {
            AppointmentId: 0, AppointmentDate: new Date(), DoctorId: 0, DoctorName: "", PatientName: "", PatientId: "", Mobile: "", Email: "", UpdatedOn: new Date()
        };
        var dropdownlist = $("#DoctorList").data("kendoDropDownList"); dropdownlist.value(0);
        var datetimepicker = $("#AppointmentDate").data("kendoDateTimePicker"); datetimepicker.value(new Date());
        $scope.errormessage = $scope.errorstring;
        $scope.buttontext = "Add Appointment";
    }

    $scope.saveappointment = function (appointment) {

        var dropdownlist = $("#DoctorList").data("kendoDropDownList");
        var datetimepicker = $("#AppointmentDate").data("kendoDateTimePicker");
        if (dropdownlist.value().trim() == "" || appointment.PatientName.trim() == "") {
            $scope.errormessage = $scope.errorstring;
            return false;
        }
        else {
            $scope.errormessage = $scope.emptystring;
            appointment.DoctorId = dropdownlist.value();
            appointment.DoctorName = dropdownlist.text();
            appointment.AppointmentDate = datetimepicker.value();
            $.ajax({
                url: "/Appointment/Save",
                async: false,
                type: "POST",
                data: JSON.stringify(appointment),
                dataType: "json",
                contentType: "application/json; charset=utf-8",
                success: function (e) {
                    RefreshGrid();
                    $scope.refreshappointment();
                },
                error: function (e) {
                    alert("Record could not be saved");
                }
            });
        }
    }

    $scope.deleteappointment = function (id) {
        var retVal = confirm('Are you sure you want to delete the record?');
        if (retVal) {
            var url = '/Appointment/Delete?id=' + id;
            $.ajax({
                url: url,
                type: 'POST',
                datatype: 'json',
                success: function (e) {
                    RefreshGrid();
                    $scope.refreshappointment();
                },
                error: function (error) {
                    alert("Record could not be deleted");
                    return false;
                }
            });
        }
    }
}


function Edit(e) {
    var dataItem = this.dataItem($(e.target).closest("tr"));
    var scope = angular.element("#AppointmentId").scope();
    scope.$apply(function () {
        scope.appointment = dataItem;
        var dropdownlist = $("#DoctorList").data("kendoDropDownList"); dropdownlist.value(scope.appointment.DoctorId);
        var datetimepicker = $("#AppointmentDate").data("kendoDateTimePicker"); datetimepicker.value(scope.appointment.AppointmentDate);
        scope.buttontext = "Update Appointment";
    });
    return false;
}

function Delete(e) {
    var dataItem = this.dataItem($(e.target).closest("tr"));
    angular.element("#AppointmentId").scope().deleteappointment(dataItem.AppointmentId);
    return false;
}

function RefreshGrid() {
    var grid = $("#AppointmentGrid").data("kendoGrid");
    grid.dataSource.read();
}

function additionalInfo() {
    return {
        startdate: kendo.toString($("#startdate").data("kendoDatePicker").value(), 'd'),
        enddate: kendo.toString($("#enddate").data("kendoDatePicker").value(), 'd')
    }
}
