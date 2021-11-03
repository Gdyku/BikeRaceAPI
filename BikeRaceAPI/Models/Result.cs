using Microsoft.EntityFrameworkCore;
using System;
using BikeRaceAPI.CustomAttributes;

namespace BikeRaceAPI.Models
{
    public class Result
    {
        public Guid Id { get; set; }
        [StringRange(ValuesForParticipantStatus = new[] {"completed", "not completed", "disqualified" })]
        public string Status { get; set; }
        public TimeSpan? Time { get; set; }

    }
}
