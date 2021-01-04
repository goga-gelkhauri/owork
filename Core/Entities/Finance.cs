using Shared;
using Shared.Interfaces;

namespace Core.Entities
{
    public class Finance : BaseEntity,IAggregateRoot
    {
        public string PersonalNumber { get; set; }
        public string AccountNumber { get; set; }
    }
}