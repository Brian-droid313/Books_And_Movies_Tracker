using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
namespace Book_And_Movie_Tracker.Models
{
    public class MovieGenreViewModel
    {
        public List<Movie> Movies { get; set; }
        public SelectList Genres { get; set; }
        public string MovieGenre { get; set; }
        public string SearchString { get; set; }
    }
}
