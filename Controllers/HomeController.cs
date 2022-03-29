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
        private IBowlersRepository repo { get; set; }
        public HomeController(IBowlersRepository br)
        {
            repo = br;
        }

        // Index page that takes team id and returns that list of bowlers
        public IActionResult Index(int teamId)
        {
            var bowlers = repo.Bowlers.ToList();

            if (teamId == 0)
            {
                ViewBag.Team = 0;
            }
            else
            {
                ViewBag.Team = teamId;
                bowlers = repo.Bowlers.Where(x => x.TeamID == teamId).ToList();
            }
            return View(bowlers);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        // Create bowler
        [HttpPost]
        public IActionResult Create(Bowler b)
        {
            repo.CreateBowler(b);
            return RedirectToAction("Index", 0);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var bowler = repo.Bowlers.FirstOrDefault(x => x.BowlerID == id);
            return View(bowler);
        }

        // Edit bowler
        [HttpPost]
        public IActionResult Edit(Bowler b)
        {
            repo.SaveBowler(b);
            return RedirectToAction("Index", 0);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var bowler = repo.Bowlers.FirstOrDefault(x => x.BowlerID == id);
            return View(bowler);
        }

        // Delete bowler
        [HttpPost]
        public IActionResult Delete(Bowler b)
        {
            repo.DeleteBowler(b);
            return RedirectToAction("Index", 0);
        }
    }
}
