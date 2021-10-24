using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BikeRaceAPI.Models
{
    public class Participant
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public Result Result { get; set; }
        public bool Payed { get; set; }
        public int Number { get; set; }
    }
}
