using Microsoft.EntityFrameworkCore;

namespace Group6_WSAD_FinalProject.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Hobby> Hobbies { get; set; }
        public DbSet<Owner> Owners { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Owner>().HasData(
                  new Owner { Id = 1, FirstName = "Bella" }
                  //add owner here

                );

            modelBuilder.Entity<Hobby>().HasData(
                   new Hobby {Id = 1, Name = "Attending Concerts", Category="Music", Reason= "Because I love live music and especially enjoy hearing indie artists perform.", DifficultyLevel = 1, OwnerId= 1 } 
                   //add new hobbies here for the DB

                   );
        }
    

    }


}
