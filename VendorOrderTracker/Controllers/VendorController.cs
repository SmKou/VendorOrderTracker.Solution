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
    {}

    [HttpGet("/vendors/new")]
    public ActionResult New()
    {}

    [HttpPost("/vendors")]
    public ActionResult Create()
    {}
}