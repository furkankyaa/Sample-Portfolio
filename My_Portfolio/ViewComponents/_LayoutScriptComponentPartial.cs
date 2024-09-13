using Microsoft.AspNetCore.Mvc;

namespace My_Portfolio.ViewComponents
{
	public class _LayoutScriptComponentPartial:ViewComponent
	{
		public IViewComponentResult Invoke() { return View(); }
	}
}
