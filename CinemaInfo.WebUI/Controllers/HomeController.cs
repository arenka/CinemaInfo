using CinemaInfo.WebUI.Authentication;
using CinemaInfo.WebUI.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Mvc;

namespace CinemaInfo.WebUI.Controllers
{
    [CheckSessionAuthFilter]
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult GetMoviesList(MovieViewModel[] movieData)
        {
            MovieListViewModel filmList = new MovieListViewModel();
            if (movieData != null)
            {
                filmList.Movies = movieData.ToList();
            }
            return PartialView("Partial/_GetMoviesList", filmList);
        }
    }
}