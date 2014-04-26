var app = angular.module('tlieta', []);
function drugcontroller($scope) {

    $scope.buttontext = "Add Drug";

    $scope.drug = {
        BrandId: 0, BrandName: "", Company: "", Formulation: "", DrugContent: "", Instructions: "", CreatedOn: new Date()
    }

    $scope.refreshdrug = function () {
        $scope.drug = {
            BrandId: 0, BrandName: "", Company: "", Formulation: "", DrugContent: "", Instructions: "", CreatedOn: new Date()
        };
        $scope.buttontext = "Add Drug";
    }

    $scope.savedrug = function (drug) {
        $.ajax({
            url: "/Drug/Save",
            async: false,
            type: "POST",
            data: JSON.stringify(drug),
            dataType: "json",
            contentType: "application/json; charset=utf-8",
            success: function (e) {
                RefreshGrid();
                $scope.refreshdrug();
            },
            error: function (e) {
                alert("Record could not be saved");
            }
        });
    }

    $scope.deletedrug = function (id) {
        var retVal = confirm('Are you sure you want to delete the drug?');
        if (retVal) {
            var url = '/Drug/Delete?id=' + id;
            $.ajax({
                url: url,
                type: 'POST',
                datatype: 'json',
                success: function (e) {
                    RefreshGrid();
                    $scope.refreshdrug();
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
    var scope = angular.element("#BrandName").scope();
    scope.$apply(function () {
        scope.drug = dataItem;
        scope.buttontext = "Update Drug";
    });
    return false;
}

function Delete(e) {
    var dataItem = this.dataItem($(e.target).closest("tr"));
    angular.element("#BrandName").scope().deletedrug(dataItem.BrandId);
    return false;
}

function RefreshGrid() {
    var grid = $("#DrugGrid").data("kendoGrid");
    grid.dataSource.read();
}
