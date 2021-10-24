using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BikeRaceAPI.Models
{
    public class Race
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public List<Participant> Participants { get; set; }
    }
}
