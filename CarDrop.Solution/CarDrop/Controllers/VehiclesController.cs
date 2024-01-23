using Microsoft.AspNetCore.Mvc;
using CarDrop.Models;
using System.Collections.Generic;

namespace CarDrop.Controllers
{
  public class VehiclesController : Controller
  {

    [HttpGet("/vehicles")]
    public ActionResult Index()
    {

      List<Vehicle> allVehicles = Vehicle.GetAll();
      return View(allVehicles);
    }

    [HttpGet("/vehicles/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/vehicles")]
    public ActionResult Create(string name, int length, int width, int height, int weight)
    {
      Vehicle myVehicle = new Vehicle(name, length, width, height, weight);
      return RedirectToAction("Index");
    }

  }
}
