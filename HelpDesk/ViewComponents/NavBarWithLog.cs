
using AppFeatures;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ticketing.ViewComponents
{
    public class NavBarWithLog:ViewComponent
    {
        public IViewComponentResult Invoke()

        {

           var res= new ClientService().GetUser((int)HttpContext.Session.GetInt32("userID"));
            ViewBag.userLoged = res.FirstName + " " + res.LastName;

            return View();
        }
    }
}
