using FluentValidation;

namespace FluentValid
{
    public class EmployeeValidator : AbstractValidator<Employee>
    {
        public EmployeeValidator()
        {
            Include(new EmployeeSimpleValidator());
            Include(new EmployeeComplexValidator());
        }
    }
}
