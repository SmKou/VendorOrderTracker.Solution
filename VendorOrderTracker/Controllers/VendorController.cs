using VendorOrderTracker.Models;

namespace VendorOrderTracker.Controllers;

public class VendorController : Controller
{
    [HttpGet("/vendors")]
    public ActionResult Index()
    {
        return View();
    }

    [HttpGet("/vendors/{vendorName}")]
    public ActionResult Show(string vendorName)
    {
        return View();
    }

    [HttpGet("/vendors/new")]
    public ActionResult New()
    {
        return View();
    }

    [HttpPost("/vendors")]
    public ActionResult Create()
    {
        return RedirectToAction("Index");
    }
}