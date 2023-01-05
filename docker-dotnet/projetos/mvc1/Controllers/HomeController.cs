using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using mvc1.Models;

namespace mvc1.Controllers
{
    public class HomeController : Controller
    {
        private IRepository repository;
        private string message;

        public HomeController(IRepository repo, IConfiguration config){
            repository = repo;
            message = config["MESSAGE"] ?? "ASP .NET Core MVC - Docker";
        }
        
        public IActionResult Index()
        {
            ViewBag.Message = message;
            return View(repository.Produtos);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

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
}
