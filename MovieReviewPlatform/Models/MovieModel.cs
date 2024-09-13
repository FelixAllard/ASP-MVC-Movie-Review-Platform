using System.ComponentModel.DataAnnotations;

namespace MovieReviewPlatform.Models;

public class Movie
{
    [Required]
    public string Title { get; set; }

    [Required]
    public string Director { get; set; }

    [Required]
    [Range(1900, int.MaxValue, ErrorMessage = "Release year must be between 1900 and current year")]
    public int ReleaseYear { get; set; }

    [Required]
    [Range(1, 5, ErrorMessage = "Rating must be between 1 and 5")]
    public int Rating { get; set;  
    }

    public string Review { get; set; }
}