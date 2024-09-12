using Microsoft.AspNetCore.Mvc;

namespace My_Portfolio.ViewComponents
{
    public class _StatisticComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke() { return View(); }
    }
}
