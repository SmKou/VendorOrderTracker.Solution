using VendorOrderTracker.Models;

namespace VendorOrderTracker.Controllers;

public class HomeController : Controller
{
    [HttpGet("/")]
    public ActionResult Index()
    {
        return View();
    }
}