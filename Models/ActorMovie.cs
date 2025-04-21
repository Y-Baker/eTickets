using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices.Marshalling;

namespace eTickets.Models;

public class ActorMovie
{
    [ForeignKey("Actor")]
    public int ActorId { get; set; }

    [ForeignKey("Movie")]
    public int MovieId { get; set; }


    public virtual Actor? Actor { get; set; }
    public virtual Movie? Movie { get; set; }
}
