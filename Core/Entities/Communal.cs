using Shared;
using Shared.Interfaces;

namespace Core.Entities
{
    public class Communal : BaseEntity,IAggregateRoot
    {
        public string PersonalNumber { get; set; }
    }
}