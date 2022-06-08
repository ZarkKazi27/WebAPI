using Microsoft.EntityFrameworkCore;
using RestAPICoreDemo.Model;
using System;

namespace APItesting
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }

        internal void Remove(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}