using Microsoft.AspNetCore.Mvc;

namespace RocksInventory.Controllers
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