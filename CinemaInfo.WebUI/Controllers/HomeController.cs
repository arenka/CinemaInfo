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

    public class HomeController : Controller
    {
        [CheckSessionAuthFilter]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginViewModel loginViewModel)
        {
            if (ModelState.IsValid)
            {
                var user = CallUserAuthenticationAPI(loginViewModel.Email, loginViewModel.Password);
                if (user != null)
                {
                    Session["USER"] = user;
                    return RedirectToAction("Index");
                }
            }
            return View();
        }

        public ActionResult Logout()
        {
            Session.Abandon();
            return RedirectToAction("Login");
        }
        [CheckSessionAuthFilter]
        public PartialViewResult GetMoviesList(MovieViewModel[] movieData)
        {
            MovieListViewModel filmList = new MovieListViewModel();
            if (movieData != null)
            {
                filmList.Movies = movieData.ToList();
            }
            return PartialView("Partial/_GetMoviesList", filmList);
        }


        private UserResponseModel CallUserAuthenticationAPI(string email, string password)
        {
            var baseUrl = "http://localhost:5164/api/userauthentications";
            var urlParameters = $"?email={email}&password={password}";
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseUrl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.GetAsync(urlParameters).Result;
                if (response.IsSuccessStatusCode)
                {
                    var userResponse = response.Content.ReadAsStringAsync().Result;
                    var user = JsonConvert.DeserializeObject<UserResponseModel>(userResponse);
                    return user;
                }
            }
            return null;
        }
    }
}