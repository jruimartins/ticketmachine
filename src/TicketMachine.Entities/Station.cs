using System;
using System.Text.RegularExpressions;

namespace TicketMachine.Entities
{
    public class Station
    {
        public string Name { get; set; }

        public string NormalizedName { get; set; }

        public Station(string name)
        {
            Name = name.ToUpperInvariant();
            NormalizedName = RemoveAllNonAlphaChars(name.ToUpperInvariant());
        }

        private string RemoveAllNonAlphaChars(string str)
        {
            return Regex.Replace(str, @"[^a-zA-Z]+", String.Empty);
        }

    }
}
