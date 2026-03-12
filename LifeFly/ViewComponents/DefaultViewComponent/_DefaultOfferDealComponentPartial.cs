using Microsoft.AspNetCore.Mvc;

namespace LifeFly.ViewComponents.DefaultViewComponent
{
    public class _DefaultOfferDealComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
