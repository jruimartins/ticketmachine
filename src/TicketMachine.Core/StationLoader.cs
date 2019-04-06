using System.Collections.Generic;
using System.Linq;
using TicketMachine.Entities;

namespace TicketMachine.Core
{
    public static class StationLoader
    {
        public static IEnumerable<Station> LoadStations(string stationsString)
        {
            var stationList = stationsString.Split(',');
            var stations = new List<Station>();

            foreach (var station in stationList)
            {
                stations.Add(new Station(station.Trim()));
            }

            return stations.OrderBy(s => s.NormalizedName);
        }
    }
}
