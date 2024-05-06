using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Producer
    {
        [Key]

        public int Id { get; set; }

        [Display(Name = "Profile Picture URL")]

        public string picURL { get; set; }

        [Display(Name = "Profile Full Name")]

        public string fullName { get; set; }

        [Display(Name = "Profile Bio")]

        public string Bio { get; set; }

        //Relationship
        public List<Movie> Movies { get; set; }
    }
}
