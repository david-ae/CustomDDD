using CustomDDD.API.Commands;
using CustomDDD.API.Notifications;
using CustomDDD.API.Queries;
using CustomDDD.Infrastructure.Dtos;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CustomDDD.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SchoolController : ControllerBase
    {
        private readonly ISender _sender;
        private readonly IPublisher _publisher;

        public SchoolController(ISender sender, IPublisher publisher)
        {
            _sender = sender;
            _publisher = publisher;
        }

        [HttpGet]
        public async Task<ActionResult> GetPupils()
        {
            var pupils = await _sender.Send(new GetPupilsQuery());
            return Ok(pupils);
        }

        [HttpGet("{id:int}", Name = "GetPupilById")]
        public async Task<ActionResult> GetPupilById(int id)
        {
            var pupil = await _sender.Send(new GetPupilByIdQuery(id));
            return Ok(pupil);
        }

        [HttpPost]
        public async Task<ActionResult> AddPupil([FromBody] PupilDto pupil)
        {
            var newPupilToReturn = await _sender.Send(new AddPupilCommand(pupil));
            return CreatedAtRoute("GetPupilById", new { id = newPupilToReturn.Id }, newPupilToReturn);
        }
    }
}
