using System.ComponentModel.DataAnnotations;
using WebApplication1.Data.Base;

namespace WebApplication1.Models
{
    public class Producer : IEntityBase
    {
        [Key]

        public int Id { get; set; }

        [Display(Name = "Profile Picture URL")]
        [Required(ErrorMessage = "Profile Picture required")]

        public string picURL { get; set; }

        [Display(Name = "Profile Full Name")]
        [Required(ErrorMessage = "FullName is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Full Name must be between 3 and 50 chars")]

        public string fullName { get; set; }

        [Display(Name = "Profile Bio")]
        [Required(ErrorMessage = "Bio is required")]

        public string Bio { get; set; }

        //Relationship
        public List<Movie> Movies { get; set; }
    }
}
