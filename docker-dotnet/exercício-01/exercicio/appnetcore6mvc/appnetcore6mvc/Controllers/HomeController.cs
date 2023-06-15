using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using appnetcore6mvc.Models;

namespace appnetcore6mvc.Controllers;

public class HomeController : Controller
{
    private IRepository repository;
    private readonly IHttpContextAccessor? _httpContextAcessor;
    private string message;
    
    public HomeController(IRepository repo, IHttpContextAccessor httpContextAccessor)
    {
        repository = repo;
        _httpContextAcessor = httpContextAccessor;
        var hostname = _httpContextAcessor?.HttpContext?.Request.Host.Value;
        message = $"Docker - ({hostname})";
    }

    public IActionResult Index()
    {
        ViewBag.Message = message;
        return View(repository.Produtos);
    }
}
