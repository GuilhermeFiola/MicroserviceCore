using Microsoft.EntityFrameworkCore;
using MicroserviceCore.TeamService.Models;

namespace MicroserviceCore.TeamService.Persistence
{
    public class TeamDbContext : DbContext
    {
        public TeamDbContext(DbContextOptions<TeamDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.HasPostgresExtension("uuid-ossp");
        }

        public DbSet<Team> Teams { get; set; }
        public DbSet<Member> Members { get; set; }
    }
}