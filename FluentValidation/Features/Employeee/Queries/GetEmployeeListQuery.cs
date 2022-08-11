using MediatR;
using FluentValidation;

namespace FluentValid.Features.Employeee.Queries
{
    public class GetEmployeeListQuery : IRequest<List<Employee>>
    {
        
    }
}
