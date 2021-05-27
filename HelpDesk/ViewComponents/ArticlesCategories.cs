using AppFeatures;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelpDesk.ViewComponents
{
    
    public class ArticlesCategories : ViewComponent
    {
         public class tempData
        {
           public string categoryName { get; set; }
            public int categoryCount { get; set; }


        }
        public IViewComponentResult Invoke()
        {
            List<tempData> data = new List<tempData>();
            

            var res = new AppFunctions().getListCategories().Result;
            foreach (var item in res)
            {
                int a= new AppFunctions().getCountArticlesByCategory(item);
                data.Add(new tempData { categoryName=item, categoryCount=a });
            }
            ViewBag.theData = data;
            return View();
        }
    }
}
