using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using mvc6.Models;

namespace mvc6.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    private IRepository repository;
    private readonly IHttpContextAccessor _httpContextAccessor;
    private string message;

    public HomeController(ILogger<HomeController> logger, IRepository repo, IHttpContextAccessor httpContextAccessor)
    {
        _logger = logger;
        repository = repo;
        _httpContextAccessor = httpContextAccessor;
        string hname = _httpContextAccessor.HttpContext!.Request.Host.Value;
        message = $"Docker - ({hname})";
    }

    public IActionResult Index()
    {
        ViewBag.Message = message;
        return View(repository.Produtos);
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
