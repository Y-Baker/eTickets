﻿using System.ComponentModel.DataAnnotations;

namespace eTickets.Models;

public class Producer
{
    [Key]
    public int Id { get; set; }

    public string? ProfilePictureURL { get; set; }

    [Required]
    public string? FullName { get; set; }
    public string? Bio { get; set; }

    public virtual ICollection<Movie> Movies { get; set; } = new List<Movie>();
}
