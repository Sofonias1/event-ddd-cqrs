using System.ComponentModel;

namespace Event.Manager.Domain.Enums
{
    public enum EventTypes
    {
        [Description("Socials")]
        Socials,
        [Description("Classes")]
        Classes,
        [Description("Festivals")]
        Festivals,
        [Description("Sports")]
        Sports,
        [Description("Movies")]
        Movies,
        [Description("Parties")]
        Parties
    }
}
