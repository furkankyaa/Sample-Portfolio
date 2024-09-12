using Microsoft.AspNetCore.Mvc;

namespace My_Portfolio.ViewComponents
{
    public class _HeadComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();

        }
    }
}
