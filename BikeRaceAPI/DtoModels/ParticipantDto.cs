using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BikeRaceAPI.DtoModels
{
    public class ParticipantDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public ResultDto Result { get; set; }
        public bool Payed { get; set; }
        public int Number { get; set; }
    }
}
