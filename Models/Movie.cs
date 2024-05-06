using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApplication1.Data.enums;

namespace WebApplication1.Models
{
    public class Movie
    {
        [Key]

        public int Id { get; set; }
        public string name { get; set; }
        public string description { get; set; }

        public double price { get; set; }
        public string image { get; set; }
        
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }

        public MovieCategory MovieCategory { get; set; }
        public List<Actor_Movie> Actors_Movies { get; set;}

        //Cinema
        public int CinemaId {  get; set; }
        [ForeignKey("CinemaId")]
        public Cinema Cinema { get; set; }

        //Producer
        public int ProducerId { get; set; }
        [ForeignKey("ProducerId")]
        public Producer Producer { get; set; }
    }
}
