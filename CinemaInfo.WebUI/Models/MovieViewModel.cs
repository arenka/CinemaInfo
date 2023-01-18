using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CinemaInfo.WebUI.Models
{
    public class MovieViewModel
    {
        public string Poster { get; set; }
        public string Title { get; set; }
        public string Type { get; set; }
        public string Year { get; set; }
        public string imdbId { get; set; }
       
    }
}