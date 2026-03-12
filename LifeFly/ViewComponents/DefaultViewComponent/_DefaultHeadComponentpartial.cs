using Microsoft.AspNetCore.Mvc;

namespace LifeFly.ViewComponents.DefaultViewComponent
{
    public class _DefaultHeadComponentpartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
