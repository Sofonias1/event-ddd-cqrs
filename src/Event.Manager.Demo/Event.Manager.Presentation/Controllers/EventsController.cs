using Microsoft.AspNetCore.Mvc;
using MediatR;
using Event.Manager.Application.Events.Commands.CreateEvent;
using Event.Manager.Domain.Enums;

namespace Event.Manager.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        protected readonly ISender Sender;

        public EventsController(ISender sender)
        {
            Sender = sender;
        }

        [HttpPost]
        public async Task<IActionResult> CreateEvent(int id, CancellationToken cancellation)
        {

            var singleEvent = new CreateEventCommand(
                id,
                "Title1",
                "Description1",
                "LocationName1",
                "Address1",
                "City1",
                "country1",
                "starttime1",
                "endTime1",
                EventTypes.Socials,
                1
                );

            await Sender.Send<CreateEventCommand>(singleEvent, cancellation);

            return Ok(singleEvent);
        }
   

    }
}
