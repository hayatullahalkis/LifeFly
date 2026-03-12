using Microsoft.AspNetCore.Mvc;

namespace LifeFly.ViewComponents.DefaultViewComponent
{
    public class _DefaultSliderComponentpartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }   
    }
}
