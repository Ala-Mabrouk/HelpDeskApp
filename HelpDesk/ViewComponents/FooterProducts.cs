using AppFeatures;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelpDesk.ViewComponents
{
    public class FooterProducts : ViewComponent
    {
        public IViewComponentResult Invoke()

        {

            ViewBag.LatestProduct = new AppFunctions().getLatestProducts().Result;

            return View();
        }
    }
}
