var app = angular.module("myApp", []);
app.controller('myController', function ($http, EmployeeService,$scope) {

    $scope.getAll = function getAll() {
        var res = EmployeeService.GetAllEmployees().then(successCallBack, errorCallBack);

        function successCallBack(response) {
            populateEmployee(response.data);
        }

        function errorCallBack(errorResponse) {
            return errorResponse.data;
        }

        function populateEmployee(employee) {
            if (employee.length > 0) {
                $scope.employee = employee;
            }
            else {

            }
        }
    };

});