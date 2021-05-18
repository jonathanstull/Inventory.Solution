using Microsoft.AspNetCore.Mvc;
using RocksInventory.Models;
using System.Collections.Generic;
using System.Linq;

namespace RocksInventory.Controllers
{
  public class RocksController : Controller
  {
    private readonly RocksInventoryContext _db;

    public RocksController(RocksInventoryContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Rock> model = _db.Rocks.ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Rock rock)
    {
      _db.Rocks.Add(rock);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      Rock thisRock = _db.Rocks.FirstOrDefault(item => item.Id == id);
      return View(thisRock);
    }
  }
}