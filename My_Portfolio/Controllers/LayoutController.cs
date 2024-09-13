using Microsoft.AspNetCore.Mvc;

namespace My_Portfolio.Controllers
{
    public class LayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
