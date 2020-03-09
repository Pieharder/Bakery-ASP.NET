using Microsoft.AspNetCore.Mvc;
using Bakery.Model;

namespace Bakery.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Home() { return View(); }

    [Route("/menu")]
    public ActionResult Menu()
    {
      return View();
    }
    [Route("/cart")]

    public ActionResult Cart(string type, string kind, string amount)
    {

      Item item = new Item(type, kind, amount);

      return View(BakeryProducts.Items);
    }

    [Route("/show")]
    public ActionResult Show()
    {

      return View(BakeryProducts.Items);
    }
  }
}