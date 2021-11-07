using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using skills.Models;

namespace skills.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ISkillsRepository data;

        public HomeController(ILogger<HomeController> logger, ISkillsRepository repo)
        {
            _logger = logger;
            data=repo;
        }

        public IActionResult Index()
        {
            var model = data.GetAllSkills();
            return View(model);
        }

        [HttpGet]
        public IActionResult AddSkill()
        {
            var sk = new Skill{ID=4, Name="Azure Dev"};
            var result = data.AddSkill(sk);
            return RedirectToAction("Index", "Home", result);
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
