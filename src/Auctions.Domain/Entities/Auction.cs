using Auctions.Domain.ValueObjects;
using System.Collections.Generic;
using System.Linq;

namespace Auctions.Domain.Entities
{
    public class Auction
    {
        private List<Bid> bids;

        public IEnumerable<Bid> Bids => bids.OrderBy(x => x.Amount);

        public Bid Bid(Bidder bidder, Money amount)
        {
            throw new System.NotImplementedException();
        }
    }
}
