using FluentValidation;

namespace FluentValid
{
    public class EmployeeComplexValidator : AbstractValidator<Employee>
    {
        public EmployeeComplexValidator()
        {
            RuleFor(E => E.Address).Must(a => a.ToLower().Contains("street") == true).WithMessage("Address Must Contain Street");
        }
    }
}
