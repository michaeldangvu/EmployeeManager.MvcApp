using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManager.Mvc.Models
{
    public class AppDbContext:DbContext
    {
        // required so that the dependency injection framework can inject AppDbContext instances when required
        public AppDbContext(DbContextOptions<AppDbContext> options) :
            base(options)
        { }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Country> Countries { get; set; }
    }
}
// this and Country.cs and Employee.cs completes the EF Core model required for the example