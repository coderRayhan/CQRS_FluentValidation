using FluentValid.Features.Employeee.Queries;
using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FluentValid.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {

        private readonly FluentValid.IRepository<Employee> repository;
        private readonly IMediator mediator;

        public EmployeeController(IRepository<Employee> repository, IMediator mediator)
        {
            this.repository = repository;
            this.mediator = mediator;
        }
        [HttpGet]
        public async Task<List<Employee>> Get()
        {
            return await mediator.Send(new GetEmployeeListQuery());

        }

        [HttpPost]
        public IActionResult Post([FromBody] Employee employee)
        {
            repository.PostEmployee(employee);
            return Ok(employee);
        }
    }
}
