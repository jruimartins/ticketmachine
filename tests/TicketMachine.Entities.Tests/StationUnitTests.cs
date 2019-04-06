using Xunit;

namespace TicketMachine.Entities.Tests
{
    public class StationUnitTests
    {
        [Fact]
        public void StationConstructorShouldSetName()
        {
            var station = new Station("Brighton");

            Assert.Equal("BRIGHTON", station.Name);
        }

        [Fact]
        public void StationConstructorShouldSetNormalizedName()
        {
            var station = new Station("Brighton");

            Assert.Equal("BRIGHTON", station.NormalizedName);
        }

        [Fact]
        public void StationConstructorShouldNormalizeName()
        {
            var station = new Station("Charing Cross");

            Assert.Equal("CHARINGCROSS", station.NormalizedName);
        }
    }
}
