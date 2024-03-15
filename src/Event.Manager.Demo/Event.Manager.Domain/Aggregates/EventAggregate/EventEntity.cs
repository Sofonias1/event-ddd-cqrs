using Event.Manager.Domain.Base;
using Event.Manager.Domain.Enums;

namespace Event.Manager.Domain.Aggregates.EventAggregate
{
    public class EventEntity: IAggregateRoot
    {
        public EventEntity(
            int Id,
            string Title,
            string Description,
            string LocationName,
            string Address,
            string City,
            string Country,
            string StartTimeInUTC,
            string EndTimeInUTC,
            EventTypes eventTypes,
            string OrganizerId)
        {
            this.Id = Id;
            this.Title = Title;
            this.Description = Description;
            this.LocationName = LocationName;
            this.Address = Address;
            this.City = City;
            this.Country = Country;
            this.StartTimeInUTC = StartTimeInUTC;
            this.EndTimeInUTC = EndTimeInUTC;
            EventTypes = eventTypes;
            OrganizerId1 = OrganizerId;
        }
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? LocationName { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? Country { get; set; }
        public string? StartTimeInUTC { get; set; }
        public string? EndTimeInUTC { get; set; }
        public EventTypes EventTypes { get; }
        public string OrganizerId1 { get; }
        public int OrganizerId { get; set; }
    }
}
