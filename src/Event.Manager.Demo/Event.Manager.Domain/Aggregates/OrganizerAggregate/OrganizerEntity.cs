using Event.Manager.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event.Manager.Domain.Aggregates.OrganizerAggregate
{
    public class OrganizerEntity: IAggregateRoot
    {

        public OrganizerEntity(
            int id, 
            string name, 
            string email, 
            string location, 
            string web)
        {
            Id = id;
            Name = name;
            Email = email;
            Location = location;
            Web = web;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Location { get; set; }
        public string Web { get; set; }

    }
}
