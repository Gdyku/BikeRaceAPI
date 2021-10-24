using Microsoft.EntityFrameworkCore;
using System;


namespace BikeRaceAPI.Models
{
    public class Result
    {
        public Guid Id { get; set; }
        public string Status { get; set; }
        public TimeSpan Time { get; set; }

    }
}
