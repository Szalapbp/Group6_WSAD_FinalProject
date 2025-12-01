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
                  new Owner { Id = 1, FirstName = "Bella" },
                  new Owner { Id = 2, FirstName = "Blake"}
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
                   " and the concert I want to go to the most is Billie Eilish because she is my dream upcoming artist to see live.", DifficultyLevel = 1, OwnerId= 1 },
                //Blake's Hobby Data
                   new Hobby
                   {
                       Id = 2, Name = "Gaming", Category = "Video Games",
                       Reason = "Gaming is one of my favorite passtimes and I enjoy both playing " +
                   "alone and with friends. Genres I enjoy most include Survival, Simulation, Action/Adventure, Sports, and FPS. Some of my favorite games to " +
                   "play include Ark: Survival Evolved/Ascended, Elite Dangerous, RocketLeague, Deep Rock Galactic, Battlefield 6, and Rust. I have been " +
                   "playing video games since I was very young and started out on the PlayStation 1. One of the first games I remember playing was " +
                   "the original Gran Turismo and Crash Bandicoot. One of the physically oldest games I have extensively played is Toejam and Earl " +
                   "on the Sega Genesis. Since then, I have owned Playstation 2, 3, and 4, the Xbox 360, One, and Series X, the Nintendo DS, 3DS, WII, " +
                   "and Switch Lite, the Oculus Quest 1 and 2, and more recently I built a Gaming PC. Across all those systems I've likely owned or " +
                   "played hundreds of games and logged many tens of thousands of hours playing them. ", DifficultyLevel = 1, OwnerId = 2 }
                    


                   //add new hobbies here for the DB

                   );
        }
    

    }


}
