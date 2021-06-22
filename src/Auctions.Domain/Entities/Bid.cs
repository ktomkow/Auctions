using Auctions.Domain.ValueObjects;
using System;

namespace Auctions.Domain.Entities
{
    public class Bid
    {
        public Money Amount { get; private set; }

        public Bidder Bidder{ get; private set; }

        public DateTime Date { get; private set; }

        public Bid(Money amount, Bidder bidder)
        {
            this.Amount = amount ?? throw new ArgumentNullException(nameof(amount));
            this.Bidder = bidder ?? throw new ArgumentNullException(nameof(bidder));

            this.Date = DateTime.UtcNow;
        }
    }
}
