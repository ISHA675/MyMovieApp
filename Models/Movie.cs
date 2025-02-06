using System.ComponentModel.DataAnnotations;
namespace MyMovieApp.Models;

public class Movie{

    public int Id { get; set; }
    [Required]
    public string Title {get; set;}
    [Required]
    public string Genre{get;set;}
    [Required]
    [Range(1900,2024,ErrorMessage="Year must be between 1900 and 2024!")]
    public int ReleaseYear{ get; set;}
    [Required]
    [Range(1,5,ErrorMessage="Rating must be between 1 to 5!")]
    public double Rating {get; set;}

}
