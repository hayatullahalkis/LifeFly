using Microsoft.AspNetCore.Mvc;

namespace LifeFly.ViewComponents.DefaultViewComponent
{
    public class _DefaultPopulerDestinationComponentPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
