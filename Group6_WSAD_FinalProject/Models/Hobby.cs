using System.ComponentModel.DataAnnotations;

namespace Group6_WSAD_FinalProject.Models
{
    public class Hobby
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Category { get; set; }

        [Required]
        public string Reason { get; set; }

        [Required]
        [Range(1, 5, ErrorMessage = "Difficulty must be between 1 and 5.")]
        public int  DifficultyLevel { get; set; }

        [Required]
        public int OwnerId { get; set; }

        public Owner Owner { get; set; }

    }
}
