using Microsoft.AspNetCore.Mvc;
using Salon.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;

namespace HairSalon.Controllers
{
  public class AppointmentsController : Controller
  {
    private readonly SalonContext _db;

    public AppointmentsController(SalonContext db)
    {
      _db = db;
    } 

    public ActionResult Create()
    {
      ViewBag.StylistId = new SelectList(_db.Stylists, "StylistId", "Name");
      return View();
    }

    [HttpPost]
    public ActionResult Create(Appointment appointment)
    {
      try
      {
          _db.Appointments.Add(appointment);
          _db.SaveChanges();
          return RedirectToAction("Index", "Stylists");
      }
      catch (Exception ex)
      {
        return View("Error", ex.Message);
      }
    }
  }
}