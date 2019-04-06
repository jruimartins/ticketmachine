using System.Collections.Generic;

namespace TicketMachine.Entities
{
    public class Suggestions
    {
        public Suggestions(IEnumerable<string> stations, List<char> nextLetters)
        {
            NextLetters = nextLetters;
            Stations = stations;
        }

        public List<char> NextLetters { get; }
        
        public IEnumerable<string> Stations { get; }

        public string StationsToString()
        {
            return string.Join(System.Environment.NewLine, Stations);
        }

        public string NextLettersToString()
        {
            return string.Join(System.Environment.NewLine, NextLetters);
        }
    }
}
