using Microsoft.AspNetCore.Mvc;

namespace LifeFly.ViewComponents.BookingViwComponent
{
    public class _BookingTagsComponentPartial: ViewComponent
    {
        public IViewComponentResult Invoke(List<string> tags)
        {
            return View(tags);
        }
    }
}
