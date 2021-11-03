using BikeRaceAPI.CustomAttributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BikeRaceAPI.DtoModels
{
    public class ResultDto
    {
        public Guid Id { get; set; }
        [StringRange(ValuesForParticipantStatus = new[] { "completed", "not completed", "disqualified" })]
        public string Status { get; set; }
        public TimeSpan Time { get; set; }
    }
}
