using APItesting.DepartmentService;
using APItesting.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APItesting.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DepartmentController : ControllerBase
    {
        private readonly IDepartmentService _departmentService;
        public DepartmentController(IDepartmentService departmentService)
        {
            _departmentService = departmentService;
        }

        [HttpGet(Name = "GetDepartments")]
        //[Route("[action]")]
        //[Route("api/Department/GetDepartment")]
        public IEnumerable<Department> GetDepartments()
        {
            return _departmentService.GetDepartment();
        }

        [HttpPost(Name ="AddDepartments")]
        //[Route("[action]")]
        //[Route("api/Department/AddDepartment")]
        public IActionResult AddDepartment(Department department)
        {
            _departmentService.AddDepartment(department);
            return Ok();
        }

        [HttpPut(Name ="UpdateDepartments")]
        //[Route("[action]")]
        //[Route("api/Department/UpdateDepartment")]
        public IActionResult UpdateDepartment(Department department)
        {
            _departmentService.UpdateDepartment(department);
            return Ok();
        }

        [HttpDelete(Name = "DeleteDepartments")]
        //[Route("[action]")]
        //[Route("api/Department/DeleteDepartment")]
        public IActionResult DeleteDepartment(int id)
        {
            var existingDepartment = _departmentService.GetDepartment(id);
            if (existingDepartment != null)
            {
                _departmentService.DeleteDepartment(existingDepartment.Id);
                return Ok();
            }
            return NotFound($"Department Not Found with ID : {existingDepartment.Id}");
        }

        [HttpGet("Id", Name = "GetDepartment")]
        //[Route("GetDepartment")]
        public Department GetDepartment(int id)
        {
            return _departmentService.GetDepartment(id);
        }
    }
}
