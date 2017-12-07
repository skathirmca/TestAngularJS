app.factory("EmployeeService", service);
service.$inject = ['$http', '$log'];

function service($http, $log) {
    return {
        GetAllEmployees: getAllEmployees,
        GetEmployee: getEmployee
    };

    function getEmployee(employeeId) {
        var url = "http://localhost:63860/api/Employee/" + employeeId;
        return $http.get(url);
    };

    function getAllEmployees() {
        var url = "http://localhost:63860/api/Employee/";
        return $http.get(url);
    };
};
