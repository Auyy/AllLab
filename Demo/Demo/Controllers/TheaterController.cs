using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Demo.Models;
using Demo.Repositories;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Demo.Controllers
{
    public class TheaterController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            var theaterRepository = new TheaterRepository();
            var theater = theaterRepository.GetAll();

            return View(theater);
        }

        public IActionResult Create(Theater theater)
        {
            var theaterRepository = new TheaterRepository();
            var response = theaterRepository.Add(theater);
            return View(response);
        }


        public IActionResult Detail(int id)
        {
            var theaterRepository = new TheaterRepository();
            var response = theaterRepository.GetById(id);

            return View(response);
        }


        public IActionResult Edit(Theater theater, int id)
        {
            var theaterRepository = new TheaterRepository();
            var response = theaterRepository.Update(theater, id);

            return View(response);
        }

        public IActionResult Delete(int id)
        {
            var theaterRepository = new TheaterRepository();
            var response = theaterRepository.Delete(id);

            return View(response);
        }
    }
}
