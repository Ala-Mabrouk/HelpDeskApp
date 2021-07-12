using AppFeatures;
using Entities.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
namespace HelpDesk.Controllers
{
   // [Authorize(Roles = "Admin,SuperAdmin")]
    public class AdminController : Controller
    {
        private readonly IHttpContextAccessor httpContextAccessor;


        private readonly AppFunctions _AppFunctions = new AppFunctions();


        //for getUserPermissions from the tables

        private readonly AdminServices _AdminFunctions = new AdminServices();

  




        public ActionResult ShowAgents()
        {
            List<Agent> agentsList = _AdminFunctions.ShowAgents().Result;
            if (agentsList == null)
            {
                //rederect to erreur page for case erreur
                return RedirectToAction("Erreur404", "Home");

            }
            ViewBag.agentsList = agentsList;

            return View();


        }

        [HttpGet]
        public IActionResult EditAgent(string mail)
        {
            Agent ag = (Agent)_AppFunctions.GetUserByEmail(mail).Result;

            return View(ag);

        }

        [HttpGet]
        public IActionResult EditAgentPermission(string mail)
        {

            ViewBag.MailAgent = _AppFunctions.GetUserByEmail(mail).Result;

            List<Permission> agentPermission =new AppFunctions().getUserPermissions(mail);

          
             List<Permission> allPermission = new AppFunctions().ShowAllPermissions();


            
            //get only missing permissions (using List1 not in List2)

            ViewBag.Permissions= allPermission.Except(agentPermission).ToList();

            TempData["myAgentpermissions"] = agentPermission;
            // Agent ag = (Agent)new AppFunctions().GetUserByEmail(agentMail).Result;  

            return View();

        }

        public IActionResult addPermissiontoAgent(int permissionId, string mail)

        {


            Permission permission = _AppFunctions.getPermissionById(permissionId);


            System.Diagnostics.Debug.WriteLine("the permission name:" + permission.permissionName);
            System.Diagnostics.Debug.WriteLine("the mail User name:" + mail);
            try
            {
                _AppFunctions.addpermissionToAgent(permission, mail);
                return RedirectToAction("EditAgentPermission", "Admin", new { mail = mail });
            }
            catch (Exception e)
            {
                return RedirectToAction("Erreur404", "Home");
            }

        }

        public IActionResult deletPermissiontoAgent(int permissionId, string mail)

        {


            Permission permission = _AppFunctions.getPermissionById(permissionId);


            System.Diagnostics.Debug.WriteLine("the permission name:" + permission.permissionName);
            System.Diagnostics.Debug.WriteLine("the mail User name:" + mail);
            try
            {
                _AppFunctions.deletepermissionToAgent(permission, mail);
                return RedirectToAction("EditAgentPermission", "Admin", new { mail = mail });
            }
            catch (Exception e)
            {
                return RedirectToAction("Erreur404", "Home");
            }

        }


        [HttpPost]
        public IActionResult updateAgentPersInfo(Agent _p)
        {
            try
            {

                if (ModelState.IsValid)
                {
                    string test = Request.Form["statusValue"];

                    System.Diagnostics.Debug.WriteLine("+++++" + test);
                    if (test.Equals("true"))
                    {
                        _p.status = true;
                    }
                    else
                    {
                        _p.status = false;
                    }

                    Agent ag1 = new AgentServices().updateAgentInfo(_p).Result;

                    if (ag1 != null)
                    {


                        return RedirectToAction("EditAgent", "Admin", new { mail = ag1.Email });


                    }

                }
                //   ModelState.AddModelError("", "Unable to update info for now! try later ");

                return View("EditAgent", _p);
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e);
                return RedirectToAction("Error404");
            }


        }

        [HttpPost]
        //used to change selected agent password
        public IActionResult changeAgentPassword(Agent a)
        {


            /*            string oldpass = Request.Form["Id"];
            */
            string newpass = Request.Form["newPass"];
            string confirmPass = Request.Form["confirmNewPass"];
            if (newpass.Equals(confirmPass))
            {

                if (!_AdminFunctions.changeAgentPassword(a.Email, newpass).Result)
                {
                    ViewBag.erreurChanging = "no changes have been made ";
                    return RedirectToAction("Erreur404", "Home");
                }
                else
                {
                    return RedirectToAction("EditAgentPermission", "Admin", new { mail = a.Email });

                }
            }
            return RedirectToAction("Erreur404", "Home");

        }



        [HttpGet]
        public ActionResult addAgent()
        {

            //getting role List
            ViewBag.RoleList = new SelectList(_AppFunctions.getRolesForAgents(), "roleId", "roleName");
            return View();

        }


        [HttpPost]
        public ActionResult addAgent(Agent agent)
        {

            if (ModelState.IsValid)
            {



                if (_AdminFunctions.addAgent(agent).Result != null) return RedirectToAction("ShowAgents", "Admin");

                return RedirectToAction("Erreur404", "Home");
            }
            else
            {
                ViewBag.RoleList = new SelectList(_AppFunctions.getRolesForAgents(), "roleId", "roleName");
                ModelState.AddModelError("", "User not Found");

            }
            return View();
        }



       

        public ActionResult agentDetails(string agentMail)
        {
            var res = _AppFunctions.GetUserByEmail(agentMail).Result;
            return PartialView(res);
        }


    }
}
