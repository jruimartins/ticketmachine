using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace TicketMachine.Entities.Tests
{
    public class SuggestionsUnitTests
    {
        private readonly IEnumerable<string> _stations;
        private readonly List<char> _nextLetters;

        public SuggestionsUnitTests()
        {
            _stations = new List<string> { "Abergavenny", "Abergele & Pensarn", "Aberystwyth" };

            _nextLetters = new List<char> { 'x', 'y'};
        }

        [Fact]
        public void SuggestionsNextLettersShouldReturnOnePerLine()
        {
            var suggestions = new Suggestions(_stations, _nextLetters);

            Assert.Contains('x', suggestions.NextLetters);
            Assert.Equal(2, suggestions.NextLetters.Count);
        }

        [Fact]
        public void SuggestionsStationsShouldReturnOnePerLine()
        {
            var suggestions = new Suggestions(_stations, _nextLetters);

            Assert.Contains("Abergavenny", suggestions.Stations);
            Assert.Equal(3, suggestions.Stations.Count());

        }


    }
}
