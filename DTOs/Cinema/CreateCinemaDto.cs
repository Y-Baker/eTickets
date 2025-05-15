using System;
using System.ComponentModel.DataAnnotations;

namespace eTickets.DTOs.Cinema;

public class CreateCinemaDto
{
    [Display(Name = "Logo")]
    [Required(ErrorMessage = "Logo URL is required")]
    public string Logo { get; set; } = string.Empty;

    [Required(ErrorMessage = "Cinema name is required")]
    [StringLength(50, MinimumLength = 3, ErrorMessage = "Cinema name must be between 3 and 50 characters")]
    [Display(Name = "Cinema Name")]
    public string Name { get; set; } = string.Empty;

    [Required(ErrorMessage = "Description is required")]
    [StringLength(500, ErrorMessage = "Description must be a maximum of 500 characters")]
    [Display(Name = "Description")]
    public string Description { get; set; } = string.Empty;
}
