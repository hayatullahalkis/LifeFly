using Microsoft.AspNetCore.Mvc;

namespace LifeFly.ViewComponents.DefaultViewComponent
{
    public class _DefaultHeaderComponentpartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
