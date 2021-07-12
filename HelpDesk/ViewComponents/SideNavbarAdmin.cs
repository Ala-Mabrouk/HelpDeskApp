using AppFeatures;
using Entities.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelpDesk.ViewComponents
{
    public class SideNavbarAdmin: ViewComponent
    {
        public IViewComponentResult Invoke(string mail)
        {

            User res = new AppFunctions().GetUserByEmail(mail).Result;

            List<String> listPer = new List<string>();

            //getting the user permissions
            foreach (var item in res.listUserPermissions)
            {
                listPer.Add(item.permision.permissionName);
            }


          

            ViewBag.listPermissions = listPer;
            return View(res);

        }



    }
}

