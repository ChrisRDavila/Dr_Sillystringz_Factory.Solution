using Microsoft.AspNetCore.Mvc;



namespace Factory.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    // Notice the changes below!
    public ActionResult File() { return View(); }
  }
}