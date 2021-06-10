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

           /* List<Permission> a = new AppFunctions().getUserPermissions(agentMail);
            ViewBag.AgentPermission = a;*/

            ViewData["myAgentpermissions"] = new AppFunctions().getUserPermissions(agentMail);
            ViewBag.Permissions = new AppFunctions().ShowAllPermissions();

            Agent ag = (Agent)new AppFunctions().GetUserByEmail(agentMail).Result;

            return View();


        }

        public IViewComponentResult addToAgent(Permission _permission)
        {
            List<Permission> a = (List<Permission>)ViewData["myAgentpermissions"];
            a.Add(_permission);
            ViewData["myAgentpermissions"] = a;
            return View();
        }

        /*    public void mangepermissions()
            {

                //creating the session of permisssions
                ViewData["myAgentpermissions"] = new AppFunctions().getUserPermissions(agentMail);
                ViewBag.Permissions = new AppFunctions().ShowAllPermissions();


            }*/

    }
}
