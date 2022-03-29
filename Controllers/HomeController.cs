using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mission13.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission13.Controllers
{
    public class HomeController : Controller
    {
        private BowlersDbContext context { get; set; }
        public HomeController(BowlersDbContext bc)
        {
            context = bc;
        }

        public IActionResult Index()
        {
            var bowlers = context.Bowlers.ToList();
            return View(bowlers);
        }
    }
}
