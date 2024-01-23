using Microsoft.AspNetCore.Mvc;

namespace CarDrop.Controllers
{
    public class HomeController : Controller
    {

      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }

    }
}
