using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MotorShift_Rentals.Models;

namespace MotorShift_Rentals.Controllers;

public class Vehiclecontroller : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(VehicleModel vehicle)
    {
        if (!ModelState.IsValid) return View(vehicle);
        return RedirectToAction(nameof(Index));
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
