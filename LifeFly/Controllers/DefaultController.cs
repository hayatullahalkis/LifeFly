using Microsoft.AspNetCore.Mvc;

namespace LifeFly.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
