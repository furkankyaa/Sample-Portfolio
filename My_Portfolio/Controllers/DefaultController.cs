using Microsoft.AspNetCore.Mvc;

namespace My_Portfolio.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
