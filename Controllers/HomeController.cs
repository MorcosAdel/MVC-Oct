using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVC_Oct.Models;
using Microsoft.Extensions.Localization;


namespace MVC_Oct.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger?? throw new ArgumentNullException(nameof(logger));
    }
   private readonly IStringLocalizer<HomeController> _localizer;
    public HomeController(IStringLocalizer<HomeController> localizer)
    {
        _localizer = localizer?? throw new ArgumentNullException(nameof(localizer));
    }



    public IActionResult Index()
    {
        
        ViewData["WelcomeMessage"] = _localizer["Welcome"];
        return View();
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
