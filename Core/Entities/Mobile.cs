using Shared;
using Shared.Interfaces;

namespace Core.Entities
{
    public class Mobile : BaseEntity,IAggregateRoot
    {
        public Mobile()
        {
            //CalculateCommission();
        }

        private void CalculateCommission()
        {
            var com = this.Amount / 100;
            this.Commission = com < 0.5f ? 0.5f : com;
        }
    }
}