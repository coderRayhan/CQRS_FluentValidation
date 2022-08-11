using FluentValidation;

namespace FluentValid
{
    public interface IRepository<T> where T : class
    {
        void PostEmployee(T entity);
        Task<List<Employee>> GetEmployees();
    }
}