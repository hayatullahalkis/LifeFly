using Microsoft.AspNetCore.Mvc;

namespace LifeFly.Areas.Admin.ViewComponents
{
    public class _AdminHeadComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        { 
            return View();
        }
    }
}
