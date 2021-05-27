using AppFeatures;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelpDesk.ViewComponents
{
    public class ExampleArticles : ViewComponent
    {
        public IViewComponentResult Invoke(string category)

        {

            var res = new AppFunctions().getListArticlesByCategory(category).Result;
            ViewBag.listArticles = res;
            ViewBag.category = category;
            ViewBag.countForCategory = new AppFunctions().getCountArticlesByCategory(category);


            return View();
        }
    }
}
