using APItesting.EmployeeService;
using Microsoft.AspNetCore.Mvc;
using RestAPICoreDemo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APItesting.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;
        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet(Name ="GetEmployees")]
        //[Route("[action]")]
        //[Route("api/Employee/GetEmployees")]
        public IEnumerable<Employee> GetEmployees()
        {
            return _employeeService.GetEmployees();
        }

        [HttpPost(Name = "AddEmployees")]
        //[Route("[action]")]
        //[Route("api/Employee/AddEmployee")]
        public IActionResult AddEmployee(Employee employee)
        {
            _employeeService.AddEmployee(employee);
            return Ok();
        }

        [HttpPut(Name = "UpdateEmployees")]
        //[Route("[action]")]
        //[Route("api/Employee/UpdateEmployee")]
        public IActionResult UpdateEmployee(Employee employee)
        {
            _employeeService.UpdateEmployee(employee);
            return Ok();
        }

        [HttpDelete(Name = "DeleteEmployees")]
        //[Route("[action]")]
        //[Route("api/Employee/DeleteEmployee")]
        public IActionResult DeleteEmployee(int id)
        {
            var existingEmployee = _employeeService.GetEmployee(id);
            if (existingEmployee != null)
            {
                _employeeService.DeleteEmployee(existingEmployee.Id);
                return Ok();
            }
            return NotFound($"Employee Not Found with ID : {existingEmployee.Id}");
        }

        [HttpGet("Id",Name ="GetEmployee")]
        //[Route("GetEmployee")]
        public Employee GetEmployee(int id)
        {
            return _employeeService.GetEmployee(id);
        }

    }
}
