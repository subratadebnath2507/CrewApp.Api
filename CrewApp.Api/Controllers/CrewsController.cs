using CrewApp.Application.Commands;
using CrewApp.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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
    }
}
