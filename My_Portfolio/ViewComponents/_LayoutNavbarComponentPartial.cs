using Microsoft.AspNetCore.Mvc;
using My_Portfolio.DAL.Context;

namespace My_Portfolio.ViewComponents
{
	public class _LayoutNavbarComponentPartial:ViewComponent
	{
		MyPortfolioContext context = new MyPortfolioContext();
		public IViewComponentResult Invoke() {
			
			ViewBag.toDoListCount=context.ToDoLists.Where(x=>x.Status==false).Count(); 
			var values= context.ToDoLists.Where(x=>x.Status==false).ToList();

			return View(values); }
	}

}
