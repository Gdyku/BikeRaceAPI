using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BikeRaceAPI.DtoModels
{
    public class RaceDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public List<ParticipantDto> Participants { get; set; }
    }
}
