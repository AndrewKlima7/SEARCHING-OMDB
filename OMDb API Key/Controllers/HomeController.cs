using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OMDb_API_Key.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace OMDb_API_Key.Controllers
{
    public class HomeController : Controller
    {
        MovieDAL md = new MovieDAL();

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MovieSearch() //???
        {
            return View();
        }

        [HttpPost]
        public IActionResult MovieSearch(string Title)
        {
            Movie m = md.GetMovie(Title);
            return View(m);
        }

        public IActionResult MovieNight()
        {
            return View();
        }

        [HttpPost]
        public IActionResult MovieNight(string title1, string title2, string title3)
        {
            List<Movie> movies = new List<Movie>();
            Movie m1 = md.GetMovie(title1);
            Movie m2 = md.GetMovie(title2);
            Movie m3 = md.GetMovie(title3);
            movies.Add(m1);
            movies.Add(m2);
            movies.Add(m3);
            return View(movies);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
