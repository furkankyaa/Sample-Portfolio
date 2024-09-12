using Microsoft.AspNetCore.Mvc;
using My_Portfolio.DAL.Context;
using My_Portfolio.DAL.Entities;

namespace My_Portfolio.ViewComponents
{
    public class _SkillComponentPartial:ViewComponent
    {
        MyPortfolioContext context =new MyPortfolioContext();

        
        public IViewComponentResult Invoke() {
            
            var values = context.Skills.ToList();
            
            
            return View(values); }
    }
}
