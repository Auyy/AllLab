using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Demo.Models;
using Demo.Repositories;

namespace Demo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {

           var movieRepository = new MovieRepository();
           var movies = movieRepository.GetAll();
            return View(movies);
        }

        public IActionResult Create(Movie movie)
        {
            
                var movieRepository = new MovieRepository();
                var response = movieRepository.Add(movie);
                return View(response);
         
                
        }

   
    public IActionResult Detail(int id)
        {
            var movieRepository = new MovieRepository();
            var response = movieRepository.GetById(id);

            return View(response);
        }

       
        public IActionResult Edit(Movie movie ,int id)
        {
            var movieRepository = new MovieRepository();
            var response = movieRepository.Update(movie, id);

            return View(response);
        }

        public IActionResult Delete(int id)
        {
            var movieRepository = new MovieRepository();
            var response = movieRepository.Delete(id);

            return View(response);
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
