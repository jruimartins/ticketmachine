using TicketMachine.Entities;

namespace TicketMachine.Core
{
    public class Machine : IMachine
    {
        private IStationFinder _stationFinder;
        
        public Machine(IStationFinder stationFinder)
        {
            _stationFinder = stationFinder;
        }

        public Suggestions FindStation(string userInput)
        {
            return _stationFinder.GetSuggestions(userInput);
        }
    }
}
