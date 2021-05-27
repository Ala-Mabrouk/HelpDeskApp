using AppFeatures;
using Entities.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelpDesk.ViewComponents
{
    public class UpdatePermissions:ViewComponent
    {

        public IViewComponentResult Invoke(string agentMail)
        {

            List<Permission> a = new AppFunctions().getUserPermissions(agentMail);
            ViewBag.AgentPermission = a;

            ViewBag.Permissions = new AppFunctions().ShowAllPermissions();

            Agent ag = (Agent)new AppFunctions().GetUserByEmail(agentMail).Result;

            return View(ag);


        }


    }
}
