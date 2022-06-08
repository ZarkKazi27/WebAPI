using RestAPICoreDemo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APItesting.EmployeeService
{
    public interface IEmployeeService
    {
        Employee AddEmployee(Employee employee);

        List<Employee> GetEmployees();

        void UpdateEmployee(Employee employee);

        void DeleteEmployee(int Id);

        Employee GetEmployee(int Id);
    }
}
