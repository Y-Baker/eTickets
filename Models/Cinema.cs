﻿using System.ComponentModel.DataAnnotations;

namespace eTickets.Models;

public class Cinema
{
    [Key]
    public int Id { get; set; }

    [Display(Name = "Logo")]
    public string? Logo { get; set; }

    [Required]
    [Display(Name = "Cinema Name")]
    public string? Name { get; set; }

    [Display(Name = "Description")]
    public string? Description { get; set; }


    public virtual ICollection<Movie> Movies { get; set; } = new List<Movie>();
}
