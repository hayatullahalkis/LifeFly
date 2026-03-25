using Microsoft.AspNetCore.Mvc;

namespace LifeFly.Areas.Admin.Controllers
{
    public class FlightsListController : Controller
    {
        [Area("Admin")]
        public IActionResult FlightList()
        {
            return View();
        }

        public IActionResult CreateFligth()
        {
            return View();
        }
    }
}
