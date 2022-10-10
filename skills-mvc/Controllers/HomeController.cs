using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using skills;

namespace skills_mvc.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private ISkillsRepository data;

    public HomeController(ILogger<HomeController> logger, ISkillsRepository repo)
    {
        _logger = logger;
        data = repo;
    }

    public IActionResult Index()
    {
        var model = data.GetAllSkills();
        return View(model);
    }

    [HttpGet]
    public IActionResult AddSkill()
    {
        var sk = new Skill { ID = 4, Name = "Azure Dev" };
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