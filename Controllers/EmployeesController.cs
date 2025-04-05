using MediatR;
using Meditation.Application.Commands;
using Meditation.Application.Queries;
using Meditation.Core.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Meditation.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController(ISender sender) : ControllerBase
    {
        [HttpPost("")] // (1)
        public async Task<IActionResult> AddEmployeeAsync([FromBody] EmployeeEntity employee)
        {
            var result = await sender.Send(new AddEmployeeCommand(employee));
            return Ok(result);
        }
        
        [HttpGet("")]
        public async Task<IActionResult> GetAllEmployeeAsync()
        {
            var result = await sender.Send(new GetAllEmployeesQuery());
            return Ok(result);
        }

        [HttpGet("{employeeId}")]
        public async Task<IActionResult> GetAllEmployeeByIdAsync([FromRoute] Guid employeeId)
        {
            var result = await sender.Send(new GetEmployeeByIdQuery(employeeId));
            return Ok(result);
        }
        
        [HttpPut("{employeeId}")]
        public async Task<IActionResult> UpdateEmployeeAsync([FromRoute] Guid employeeId, [FromBody] EmployeeEntity employee)
        {
            var result = await sender.Send(new UpdateEmployeeCommand(employeeId, employee));
            return Ok(result);
        }  
        
        [HttpDelete("{employeeId}")]
        public async Task<IActionResult> DeleteEmployeeAsync([FromRoute] Guid employeeId)
        {
            var result = await sender.Send(new DeleteEmployeeCommand(employeeId));
            return Ok(result);
        }
        

    }
}
