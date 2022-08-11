using FluentValidation;
using Microsoft.EntityFrameworkCore;

namespace FluentValid
{
    public interface IEmployeeDbContext
    {
        DbSet<Employee> Employees { get; set; }
    }
}