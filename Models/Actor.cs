using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;
using eTickets.Data.Interface;

namespace eTickets.Models;

public class Actor : IEntityBase
{
    [Key]
    public int Id { get; set; }

    [Display(Name = "Profile Picture")]
    public string? ProfilePictureURL { get; set; }

    [Required]
    [Display(Name = "Full Name")]
    public string? FullName { get; set; }

    [Display(Name = "Biography")]
    public string? Bio {  get; set; }


    public virtual ICollection<ActorMovie> ActorMovies { get; set; } = new List<ActorMovie>();
}
