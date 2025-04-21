using eTickets.Utils;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eTickets.Models;

public class Movie
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string? Name { get; set; }
    public string? Description { get; set; }
    public double Price { get; set; }
    public string? ImageURL { get; set; }
    public DateTime StartDate { get; set; } = DateTime.Now;
    public DateTime EndDate { get; set; }
    public Category Category { get; set; }

    [ForeignKey("Cinema")]
    public int CinemaId { get; set; }

    [ForeignKey("Producer")]
    public int ProducerId { get; set; }

    public virtual Cinema? Cinema { get; set; }
    public virtual Producer? Producer { get; set; }
    public virtual ICollection<ActorMovie> ActorMovies { get; set; } = new List<ActorMovie>();
}
