using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BikeRaceAPI.Models
{
    public class Race
    {
        public Race()
        {
            Participants = new List<Participant>();
        }
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Location { get; set; }
        public List<Participant> Participants { get; set; }
    }
}
