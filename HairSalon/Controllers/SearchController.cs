using Microsoft.AspNetCore.Mvc;
using Salon.Models;
using System.Collections.Generic;

namespace Salon.Controllers
{
    public class SearchController : Controller
    {
      private readonly SalonContext _db;

      public Stylist Stylist { get; set; }

      [HttpGet("/search")]
      public ActionResult Index()
      {
        return View();
      }

      [HttpPost("/search/stylists")]
      public ActionResult Show(string name)
      {
        List<Stylist> stylistList = new List<Stylist> { };
        stylistList = Stylist.FindByStylistName(name);
        return View(stylistList);
      }

    }
}