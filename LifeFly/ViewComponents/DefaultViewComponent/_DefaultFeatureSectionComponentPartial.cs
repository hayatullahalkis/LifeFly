using Microsoft.AspNetCore.Mvc;

namespace LifeFly.ViewComponents.DefaultViewComponent
{
    public class _DefaultFeatureSectionComponentPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
