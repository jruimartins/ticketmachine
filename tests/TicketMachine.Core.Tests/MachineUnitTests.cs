using Moq;
using System.Collections.Generic;
using TicketMachine.Entities;
using Xunit;

namespace TicketMachine.Core.Tests
{
    public class MachineUnitTests
    {
        private readonly IMachine _ticketMachine;
        private readonly Mock<IStationFinder> _stationFinder;

        public MachineUnitTests()
        {
            _stationFinder = new Mock<IStationFinder>();
            _ticketMachine = new Machine(_stationFinder.Object);
        }

        [Fact]
        public void FindStationShouldGetAndReturnSuggestionsForUserInput()
        {
            var userInput = "BRI";
            var suggestions = new Suggestions(new List<string>{ "Brighton" }, new List<char> { 'g' });

            _stationFinder.Setup(sf => sf.GetSuggestions(userInput)).Returns(suggestions);

            var result =_ticketMachine.FindStation(userInput);

            Assert.Equal(suggestions, result);
        }

       
    }
}
