using Microsoft.AspNetCore.Mvc;
using Factory.Models;
using System.Collections.Generic;
using System;
using System.Linq;

namespace Factory.Controllers
{
  public class HomeController : Controller
  {
    private readonly FactoryContext _db;

    public HomeController(FactoryContext db)
    {
      _db = db;
    }

    [HttpGet("/")]
    public ActionResult Index()
    {
      Engineer[] engineers = _db.Engineers.OrderBy(engineers => engineers.Name).ToArray();
      Machine[] machines = _db.Machines.OrderBy(machines => machines.Model).ToArray();
      Dictionary<string,object[]> model = new Dictionary<string, object[]>();
      model.Add("engineers", engineers);
      model.Add("machines", machines);
      return View(model);
    }

  }
}
