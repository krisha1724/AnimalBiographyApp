using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AnimalBiographyApp.Models;
using AnimalBiographyApp.Data;
using Microsoft.EntityFrameworkCore;

namespace AnimalBiographyApp.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly ApplicationDbContext _context;

    public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
    {
        _logger = logger;
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        var featuredAnimals = await _context.Animals
            .OrderByDescending(a => a.DateAdded)
            .Take(3)
            .ToListAsync();

        return View(featuredAnimals);
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
