using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;
using System.Collections.Generic;
using System.Linq;

namespace HairSalon.Controllers
{
    public class HomeController : Controller
    {
      private readonly HairSalonContext _db;
      public HomeController(HairSalonContext db)
      {
        _db = db;
      }
      [HttpGet("/")]
      public ActionResult Index()
      {
        List<Stylist> model = _db.Stylists.ToList();
        ViewBag.PageTitle = "Stylist Tracker";
        return View(model);
      }
    }
}