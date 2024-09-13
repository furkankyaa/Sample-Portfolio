using Microsoft.AspNetCore.Mvc;

namespace My_Portfolio.ViewComponents
{
	public class _LayoutSiderbarComponentPartial:ViewComponent
	{
		public IViewComponentResult Invoke() { return View(); }
	}
}
