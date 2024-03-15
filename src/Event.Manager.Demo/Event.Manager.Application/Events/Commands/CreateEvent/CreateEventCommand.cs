using Event.Manager.Domain.Enums;
using MediatR;

namespace Event.Manager.Application.Events.Commands.CreateEvent
{
    public sealed record CreateEventCommand(
    int Id,
    string Title,
    string Description,
    string LocationName,
    string Address,
    string City,
    string Country,
    string StartTimeInUTC,
    string EndTimeInUTC,
    EventTypes Type,

    int OrganizerId) : IRequest;
    
}
