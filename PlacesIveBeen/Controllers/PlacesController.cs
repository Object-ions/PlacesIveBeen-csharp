using Microsoft.AspNetCore.Mvc;
using PlacesIveBeen.Models;
using System.Collections.Generic;

namespace PlacesIvBeen.Controllers
{
  public class PlacesController : Controller
  {

    [HttpGet("/city")]
    public ActionResult Index()
    {
      List<Place> allPlaces = Place.GetAll();
      return View(allPlaces);
    }

    // [HttpGet("/city/new")]
    // public ActionResult New()
    // {
    //   return View();
    // }
  }
}