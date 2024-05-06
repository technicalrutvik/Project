using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Cinema
    {
        [Key]

        public int Id { get; set; }
        [Display(Name = "Profile Picture Logo")]

        public string logo { get; set; }

        [Display(Name = "Profile  Name")]

        public string name { get; set; }

        [Display(Name = "Profile Description")]

        public string description { get; set; }

        public List<Movie> Movies { get; set; }

    }
}
