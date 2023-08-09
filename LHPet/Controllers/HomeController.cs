using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHPet.Models;

namespace LHPet.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        Cliente cliente1 = new Cliente(01, "Arthur A. 
Ferreira", "857.032.950-41", "arthur.antunes@sp.senai.br", 
"Madruga");
Cliente cliente2 = new Cliente(02, "William Henry 
Gates III", "039.618.250-09", "bill@microsoft.com", "Bug");
Cliente cliente3 = new Cliente(03, "Ada Lovelace", 
"800.777.920-50", "ada@ada.language.com", "Byron");
Cliente cliente4 = new Cliente(04, "Linus 
Torvalds", "933.622.400-03", "torvalds@osdl.org", 
"Pinguim");
Cliente cliente5 = new Cliente(05, "Grace Hopper", 
"911.702.988-00", "grace.hopper@cobol.com", "Loboc");
return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
