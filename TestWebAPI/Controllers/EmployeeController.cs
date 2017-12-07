using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TestWebAPI.Models;

namespace TestWebAPI.Controllers
{
    public class EmployeeController : ApiController
    {
        // GET api/employee
        [AllowAnonymous]
        [AllowCrossSiteJson]
        public HttpResponseMessage Get()
        {
            HttpResponseMessage response = new HttpResponseMessage();
            List<Employee> employeeList = new List<Employee>();
            Employee e1 = new Employee() { EmployeeID = 1, EmployeeName = "David", Age = 25 };
            Employee e2 = new Employee() { EmployeeID = 2, EmployeeName = "Anderson", Age = 25 };
            Employee e3 = new Employee() { EmployeeID = 3, EmployeeName = "John", Age = 25 };
            employeeList.Add(e1);
            employeeList.Add(e2);
            employeeList.Add(e3);
            return Request.CreateResponse(HttpStatusCode.OK, employeeList);
        }

        // GET api/employee/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/employee
        public void Post([FromBody]string value)
        {
        }

        // PUT api/employee/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/employee/5
        public void Delete(int id)
        {
        }
    }
}
