using System.ComponentModel.DataAnnotations;
using WebApplication1.Data.Base;

namespace WebApplication1.Models
{
    public class Cinema : IEntityBase
    {
        [Key]

        public int Id { get; set; }
        [Display(Name = " Picture Logo")]

        public string logo { get; set; }

        [Display(Name = "  Name")]

        public string name { get; set; }

        [Display(Name = " Description")]

        public string description { get; set; }

        public List<Movie> Movies { get; set; }

    }
}
