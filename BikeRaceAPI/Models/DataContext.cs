using Microsoft.EntityFrameworkCore;


namespace BikeRaceAPI.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Participant> Participants { get; set; }
        public DbSet<Race> Races { get; set; }
        public DbSet<Result> Results { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
