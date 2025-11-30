namespace Group6_WSAD_FinalProject.Models
{
    public class Owner
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public List<Hobby> Hobbies { get; set; }
    }
}
