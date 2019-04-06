using TicketMachine.Entities;

namespace TicketMachine.Core
{
    public interface IMachine
    {
        Suggestions FindStation(string userInput);
    }
}