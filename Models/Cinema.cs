using System.ComponentModel.DataAnnotations;

namespace eTickets.Models;

public class Cinema
{
    [Key]
    public int Id { get; set; }

    public string? Logo { get; set; }

    [Required]
    public string? Name { get; set; }

    public string? Description { get; set; }


    public virtual ICollection<Movie> Movies { get; set; } = new List<Movie>();
}
