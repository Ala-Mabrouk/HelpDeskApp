using AppFeatures;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelpDesk.ViewComponents
{
    public class FooterArticles:ViewComponent
    {

        public IViewComponentResult Invoke()
        {
            ViewBag.LatestArticles = new AppFunctions().getLatestArticles().Result;

            return View();
        }


    }
}
