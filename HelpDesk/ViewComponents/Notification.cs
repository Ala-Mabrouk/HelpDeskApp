using AppFeatures;
using Entities.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelpDesk.ViewComponents
{
    public class Notification : ViewComponent
    {
        public IViewComponentResult Invoke(string mail)

        {

            User res = new AppFunctions().GetUserByEmail(mail).Result;

            var res2 = new AppFunctions().getUserNotification(res.Id);

            ViewBag.notifications = res2;

            return View();
        }
    }
}
