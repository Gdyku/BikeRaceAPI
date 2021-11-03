using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BikeRaceAPI.Models
{
    public class Participant
    {
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        public Result Result { get; set; }
        public bool Payed { get; set; }
        [Required]
        [Range(0, 1000, ErrorMessage ="Value must be set between 0 and 1000")]
        public int Number { get; set; }
    }
}
