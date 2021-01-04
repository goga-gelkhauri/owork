using Shared;
using Shared.Interfaces;

namespace Core.Entities
{
    public class Charity : BaseEntity,IAggregateRoot
    {
        public string PersonalNumber { get; set; }
    }
}