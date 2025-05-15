using System;
using System.ComponentModel.DataAnnotations;
using eTickets.Utils;

namespace eTickets.DTOs.Movie;

public class CreateMovieDto
{
    [Required(ErrorMessage = "Movie name is required")]
    [StringLength(100, MinimumLength = 3, ErrorMessage = "Movie name must be between 3 and 100 characters")]
    [Display(Name = "Movie Name")]
    public string? Name { get; set; }

    [Required(ErrorMessage = "Description is required")]
    [StringLength(500, ErrorMessage = "Description must be a maximum of 500 characters")]
    [Display(Name = "Description")]
    public string? Description { get; set; }

    [Required(ErrorMessage = "Price is required")]
    [Range(1, 1000, ErrorMessage = "Price must be between 1 and 1000")]
    [Display(Name = "Price")]
    public double Price { get; set; }

    [Required(ErrorMessage = "Image URL is required")]
    [StringLength(500, ErrorMessage = "Image URL must be a maximum of 500 characters")]
    [Display(Name = "Image URL")]
    public string? ImageURL { get; set; }

    [Required(ErrorMessage = "Start date is required")]
    [DataType(DataType.Date)]
    [Display(Name = "Start Date")]
    public DateTime StartDate { get; set; } = DateTime.Now;

    [Required(ErrorMessage = "End date is required")]
    [DataType(DataType.Date)]
    [Display(Name = "End Date")]
    public DateTime EndDate { get; set; }

    [Required(ErrorMessage = "Category is required")]
    [Display(Name = "Select Category")]
    public Category Category { get; set; }

    [Required(ErrorMessage = "Cinema is required")]
    [Display(Name = "Select Cinema")]
    public int CinemaId { get; set; }

    [Required(ErrorMessage = "Producer is required")]
    [Display(Name = "Select Producer")]
    public int ProducerId { get; set; }

    [Required(ErrorMessage = "Actors are required")]
    [Display(Name = "Select Actors")]
    public List<int> ActorIds { get; set; } = new List<int>();
}
