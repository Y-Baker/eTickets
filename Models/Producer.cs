using System.ComponentModel.DataAnnotations;
using eTickets.Data.Interface;

namespace eTickets.Models;

public class Producer : IEntityBase
{
    [Key]
    public int Id { get; set; }

    [Display(Name = "Profile Picture")]
    public string? ProfilePictureURL { get; set; }

    [Required]
    [Display(Name = "Full Name")]
    public string? FullName { get; set; }

    [Display(Name = "Biography")]
    public string? Bio { get; set; }

    public virtual ICollection<Movie> Movies { get; set; } = new List<Movie>();
}
