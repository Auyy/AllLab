using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Demo.Repositories;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Demo.Controllers
{
    public class BroadingController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            var broadingRepository = new BroadingRepository();
            var broading = broadingRepository.GetAll();
            return View(broading);
        }
    }
}
