using Auctions.Domain.ValueObjects;
using FluentAssertions;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Auctions.Domain.ValueObjectsTests
{
    public class MoneyTests
    {
        #region Equals

        [Fact]
        public void Equals_IfTwoInstancesWithSameValue_ShouldBeTrue()
        {
            Money m1 = new Money(1.0m);
            Money m2 = new Money(1.0m);

            bool result = m1.Equals(m2);

            result.Should().BeTrue();
        }

        [Fact]
        public void Equals_IfTwoInstancesWithDifferentValue_ShouldBeTrue()
        {
            Money m1 = new Money(31.99m);
            Money m2 = new Money(1.0m);

            bool result = m1.Equals(m2);

            result.Should().BeFalse();
        }

        [Fact]
        public void Equals_IfOneInstance_ShouldBeEqualToItself()
        {
            Money m1 = new Money(31.99m);

            bool result = m1.Equals(m1);

            result.Should().BeFalse();
        }

        [Fact]
        public void Equals_IfComparedToNull_ShouldBeFalse()
        {
            Money m1 = new Money(99.99m);

            bool result = m1.Equals(null);

            result.Should().BeFalse();
        }

        #endregion Equals

        #region Add

        [Fact]
        public void Add_IfSomethingAddedToObject_OriginalInstanceShouldNotChange()
        {
            Money m1 = new Money(10.00m);
            Money m2 = new Money(20.00m);

            m1.Add(m2);

            m1.Should().Be(new Money(10.00m));
        }

        [Fact]
        public void Add_If2AddedTo1_ResultShouldBe3()
        {
            Money m1 = new Money(1.00m);
            Money m2 = new Money(2.00m);
            Money expected = new Money(3.00m);

            Money result = m1.Add(m2);

            result.Should().Be(expected);
        }

        [Fact]
        public void Add_If0AddedTo0_ResultShouldBe0()
        {
            Money m1 = new Money(0m);
            Money m2 = new Money(0m);
            Money expected = new Money(0m);

            Money result = m1.Add(m2);

            result.Should().Be(expected);
        }

        [Fact]
        public void Add_IfNegative5AddedTo2_ResultShouldBeNegative3()
        {
            Money m1 = new Money(2m);
            Money m2 = new Money(-5m);
            Money expected = new Money(-3m);

            Money result = m1.Add(m2);

            result.Should().Be(expected);
        }


        #endregion Add
    }
}
