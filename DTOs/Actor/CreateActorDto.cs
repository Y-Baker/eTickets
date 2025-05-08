using System;
using System.ComponentModel.DataAnnotations;

namespace eTickets.DTOs.Actor;

public class CreateActorDto
{
    [Display(Name = "Profile Picture")]
    [Required(ErrorMessage = "Profile picture URL is required")]
    public string ProfilePictureURL { get; set; } = string.Empty;

    [Required(ErrorMessage = "Full name is required")]
    [StringLength(50, MinimumLength = 3, ErrorMessage = "Full name must be between 3 and 50 characters")]
    [Display(Name = "Full Name")]
    public string FullName { get; set; } = string.Empty;

    [Required(ErrorMessage = "Biography is required")]
    [StringLength(500, ErrorMessage = "Biography must be a maximum of 500 characters")]
    [Display(Name = "Biography")]
    public string Bio { get; set; } = string.Empty;
}
