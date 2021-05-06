
using AppFeatures;
using Entities.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;


namespace ticketing.ViewComponents
{
    public class NavBarWithLog:ViewComponent
    {
        public IViewComponentResult Invoke(string mail)

        {

            User res =  new AppFunctions().GetUserByEmail(mail).Result;
 
                ViewBag.userLoged = res.FirstName + " " + res.LastName;
                ViewBag.avatar = res.ThumbUrl;
        
            return View();
        }
    }
}
