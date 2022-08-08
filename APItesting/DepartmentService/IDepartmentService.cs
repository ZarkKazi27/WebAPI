using APItesting.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APItesting.DepartmentService
{
    public interface IDepartmentService
    {
        Department AddDepartment(Department department);
        List<Department> GetDepartments();
        void UpdateDepartment(Department department);
        void DeleteDepartment(int Id);
        Department GetDepartment(int Id);
        IEnumerable<Department> GetDepartment();
    }
}
