using APItesting.Models;
using APItesting.DepartmentService;
using RestAPICoreDemo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APItesting.DepartmentService
{
    public class DepartmentService : IDepartmentService
    {
        public DepartmentContext _departmentDbContext;
        public DepartmentService(DepartmentContext departmentDbContext)
        {
            _departmentDbContext = departmentDbContext;
        }
        public Department AddDepartment( Department department)
        {
            _departmentDbContext.Departments.Add(department);
            _departmentDbContext.SaveChanges();
            return department;
        }
        public List<Department> GetDepartments()
        {
            return _departmentDbContext.Departments.ToList();
        }

        public void UpdateDepartment(Department department)
        {
            object p = _departmentDbContext.Departments.Update(department);
            _departmentDbContext.SaveChanges();
        }

        public void DeleteDepartment(int Id)
        {
            var department = _departmentDbContext.Departments.FirstOrDefault(x => x.Id == Id);
            if (department != null)
            {
                _departmentDbContext.Remove(department);
                _departmentDbContext.SaveChanges();
            }
        }

        public Department GetDepartment(int Id)
        {
            return _departmentDbContext.Departments.FirstOrDefault(x => x.Id == Id);

        }

        public IEnumerable<Department> GetDepartment()
        {

            return _departmentDbContext.Departments;
        }
    }
}
