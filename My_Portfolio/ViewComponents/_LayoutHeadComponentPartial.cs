﻿using Microsoft.AspNetCore.Mvc;

namespace My_Portfolio.ViewComponents
{
	public class _LayoutHeadComponentPartial:ViewComponent
	{
		public IViewComponentResult Invoke() {  return View(); }
	}
}
