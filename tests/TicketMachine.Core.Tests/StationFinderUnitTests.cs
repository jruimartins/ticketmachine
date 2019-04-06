using System.Linq;
using Xunit;

namespace TicketMachine.Core.Tests
{
    public class StationFinderUnitTests
    {
        private IStationFinder _stationFinder;

        public StationFinderUnitTests()
        {
            _stationFinder = new StationFinder("Brighton, Charing Cross, Hove");
        }

        [Fact]
        public void StationFinderShouldReturnAllStationsWhenNoInput()
        {
            var suggestions = _stationFinder.GetSuggestions("");

            Assert.Equal(3, suggestions.Stations.Count());
        }

        [Fact]
        public void StationFinderShouldReturnBrightonAndRForB()
        {
            var suggestions = _stationFinder.GetSuggestions("B");

            Assert.Single(suggestions.Stations);
            Assert.Contains(suggestions.Stations, s => s == "BRIGHTON");
            Assert.Contains(suggestions.NextLetters, s=> s == 'R');
        }

        [Fact]
        public void StationFinderShouldReturnNoStationsForNoMatchInput()
        {
            var suggestions = _stationFinder.GetSuggestions("X");

            Assert.Empty(suggestions.Stations);
            Assert.Empty(suggestions.NextLetters);
        }

        [Fact]
        public void StationFinderShouldReturnNoNextLetters()
        {
            var suggestions = _stationFinder.GetSuggestions("BRIGHTON");

            Assert.Single(suggestions.Stations);
            Assert.Empty(suggestions.NextLetters);
        }
    }
}
