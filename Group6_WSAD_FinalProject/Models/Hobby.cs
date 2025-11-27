using System.ComponentModel.DataAnnotations;

namespace Group6_WSAD_FinalProject.Models
{
    public class Hobby
    {
        [Required]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Category { get; set; }

        public string Reason { get; set; }

        public int  DifficultyLevel { get; set; }

        public int OwnerId { get; set; }

        public Owner Owner { get; set; }

    }
}
