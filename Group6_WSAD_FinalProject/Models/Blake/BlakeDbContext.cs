using Microsoft.EntityFrameworkCore;

namespace Group6_WSAD_FinalProject.Models.Blake
{
    public class BlakeDbContext : DbContext
    {
        public BlakeDbContext(DbContextOptions<BlakeDbContext> options) : base(options) { }
        public DbSet<BlakeProfile> BlakeProfiles { get; set; }
    }
}
