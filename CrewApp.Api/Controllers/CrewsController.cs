using CrewApp.Application.Commands;
using CrewApp.Application.Queries;
using CrewApp.Domain.Entities;
using CrewApp.Domain.Options;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace CrewApp.Api.Controllers
{ 
    [Route("api/[controller]")]

    [ApiController]
    public class CrewsController(ISender sender) : ControllerBase
    {        
        [HttpPost("")]
        public async Task<IActionResult> AddCrew([FromBody] CrewEntity crew)
        {
            var result = await sender.Send(new AddCrewCommand(crew));
            return Ok(result);
        }

        [HttpGet("")]
        public async Task<IActionResult> GetAllCrews()
        {
            var result = await sender.Send(new GetAllCrewsQuery());
            return Ok(result);
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> GetCrewById([FromRoute] Guid Id)
        {
            var result = await sender.Send(new GetCrewByIdQuery(Id));
            return Ok(result);
        }

        [HttpPut("{Id}")]
        public async Task<IActionResult> UpdateCrew([FromRoute] Guid Id, [FromBody] CrewEntity crew)
        {
            var result = await sender.Send(new UpdateCrewCommand(Id, crew));
            return Ok(result);
        }

        [HttpDelete("{Id}")]

        public async Task<IActionResult> DeleteCrew([FromRoute] Guid Id)
        {
            var result = await sender.Send(new DeleteCrewCommand(Id));
            return Ok(result);
        }


    }
}
