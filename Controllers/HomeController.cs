using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using users.Data;
using users.Models;

namespace users.Controllers
{
    public class HomeController : Controller
    {
                private readonly ApplicationDbContext _context;

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _context = context;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
          var a =  _context.user_details.Take(500000).ToList();
          ViewBag.alltrue = a.Where(x=>x.gender.Equals("Male")).Count();
          ViewBag.allfalse = a.Where(x=>x.gender.Equals("Female")).Count();


            return View(a);
        }
        public IActionResult Details(int id)
        {
            return View(_context.user_details.FirstOrDefault(x=>x.user_id==id));
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
