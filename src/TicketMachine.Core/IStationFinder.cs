using TicketMachine.Entities;

namespace TicketMachine.Core
{
    public interface IStationFinder
    {
        Suggestions GetSuggestions(string userInput);
    }
}