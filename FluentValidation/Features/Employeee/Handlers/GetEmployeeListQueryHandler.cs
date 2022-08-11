using FluentValid.Features.Employeee.Queries;
using FluentValidation;
using MediatR;

namespace FluentValid.Features.Employeee.Handlers
{
    public class GetEmployeeListQueryHandler : IRequestHandler<GetEmployeeListQuery, List<Employee>>
    {
        private readonly FluentValid.IRepository<Employee> repository;

        public GetEmployeeListQueryHandler(IRepository<Employee> repository)
        {
            this.repository = repository;
        }
        public async Task<List<Employee>> Handle(GetEmployeeListQuery request, CancellationToken cancellationToken)
        {
            return await repository.GetEmployees();
        }
    }
}
