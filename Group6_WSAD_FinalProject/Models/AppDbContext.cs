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

                //Bella's Hobby data
                   new Hobby {Id = 1, Name = "Attending Concerts", Category="Music", Reason= "I love attending concerts because live music " +
                   "feels completely different and more personal than listening at home. Over the past five years, I’ve gone to dozens of" +
                   " shows with friends, ranging from indie and pop concerts to full EDM festivals. I’ve seen artists like Conan Gray, Kesha, The Weeknd, " +
                   "COIN, The Lumineers, The Band Camino, The Driver Era, Mt. Joy, and multiple Breakaway Festivals. Concerts are one of my favorite ways to " +
                   "spend time because the energy, the atmosphere, and the shared experience with the crowd make every show unforgettable. I try to stay within " +
                   "budget and not spend more than $100 per concert, but I still prioritize going whenever I can. I already have festivals lined up for next year," +
                   " and the concert I want to go to the most is Billie Eilish because she is my dream upcoming artist to see live.", DifficultyLevel = 1, OwnerId= 1 } 
                   //add new hobbies here for the DB

                   );
        }
    

    }


}
