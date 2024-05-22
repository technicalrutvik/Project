using System.ComponentModel.DataAnnotations;
using WebApplication1.Data.Base;

namespace WebApplication1.Models
{
    public class Actor : IEntityBase
    {
        [Key]

        public int Id { get; set; }

        [Display(Name = "Profile Picture URL")]
        [Required(ErrorMessage ="Profile Picture required")]       
        public string ProfilePictureURL { get; set; }

        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "Fullname required")]


        public string fullName { get; set; }

        [Display(Name = "Bio")]
        [Required(ErrorMessage = "Bio required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Full Name must be between 3 and 50 chars")]

        public string Bio { get; set; }

        //Reference

        public List<Actor_Movie>? Actors_Movies { get; set;}
        //public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
