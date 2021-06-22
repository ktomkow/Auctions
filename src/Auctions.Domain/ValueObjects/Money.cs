namespace Auctions.Domain.ValueObjects
{
    public class Money
    {
        private readonly decimal value;

        public Money(decimal value)
        {
            this.value = value;
        }

        public Money Add(Money money)
        {
            throw new System.NotImplementedException();
        }
    }
}
