using Microsoft.AspNetCore.Mvc;

namespace LifeFly.Areas.Admin.ViewComponents
{
    public class _AdminSidebarComponentPartial :ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
