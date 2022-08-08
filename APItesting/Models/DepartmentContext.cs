using APItesting.Models;
using Microsoft.EntityFrameworkCore;
using RestAPICoreDemo.Model;
using System;

namespace APItesting
{
    public class DepartmentContext : DbContext
    {
        public DepartmentContext(DbContextOptions<DepartmentContext> options) : base(options)
        {
        }
        public DbSet<Department> Departments { get; set; }

        internal void Remove(Department department)
        {
            throw new NotImplementedException();
        }
    }
}
