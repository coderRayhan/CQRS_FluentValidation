using FluentValidation;
using Microsoft.EntityFrameworkCore;

namespace FluentValid
{
    public class EmployeeDbContext : DbContext, IEmployeeDbContext
    {
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options) : base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
    }
}
