using Microsoft.AspNetCore.Mvc;
using My_Portfolio.DAL.Context;

namespace My_Portfolio.ViewComponents
{
    public class _FeatureComponentPartial:ViewComponent
    {
        MyPortfolioContext portfolioContext =new MyPortfolioContext();
        public IViewComponentResult Invoke() { 
            var values =portfolioContext.Features.ToList();
            
            return View(values); }
                                                                            
    }
}
