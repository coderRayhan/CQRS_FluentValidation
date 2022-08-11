using FluentValidation;
using Microsoft.EntityFrameworkCore;

namespace FluentValid
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly DbSet<T> _entities;
        private readonly EmployeeDbContext _context;
        public Repository(EmployeeDbContext context)
        {
            _context = context;
            _entities = _context.Set<T>();
        }
        public void PostEmployee(T entity)
        {
            _entities.Add(entity);
            _context.SaveChanges();
        }

        public async Task<List<Employee>> GetEmployees()
        {
            return await _context.Employees.ToListAsync();
        }
    }
}
