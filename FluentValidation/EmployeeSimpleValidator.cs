using FluentValidation;

namespace FluentValid
{
    public class EmployeeSimpleValidator : AbstractValidator<Employee>
    {
        public EmployeeSimpleValidator()
        {
            RuleFor(e => e.FirstName).NotEmpty().NotNull().MaximumLength(50);
            RuleFor(e => e.LastName).NotEmpty().NotNull().MaximumLength(50);
        }
    }
}
