using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Book_And_Movie_Tracker.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Title { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [Required]
        [StringLength(30)]
        public string Genre { get; set; }

        [Display(Name = "My Rating")]
        [StringLength(5)]
        [Required]
        public string MyRating { get; set; }

        [StringLength(10)]
        [Required]
        public string Watched { get; set; }

    }
}
