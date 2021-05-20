 using AppFeatures;
using Entities.Entities;
using HelpDesk.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading;
using System.Threading.Tasks;

namespace HelpDesk.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {


        //creation of instance from AppFeatures

        private readonly ClientService _ClientCRUD = new ClientService();
        private readonly AppFunctions _AppFunctions = new AppFunctions();

        //for getUserPermissions from the tables

        private readonly AdminService _AdminFunctions = new AdminService();

        private  static string logedIn;
        private  static string roleIn;



        public AdminController()
        {
         
        }

        public IActionResult DashBoardAdmin()

        {

            logedIn = _AppFunctions.GetUserByEmail(User.FindFirstValue(ClaimTypes.Name)).Result.Email;
            roleIn = _AppFunctions.GetUserByEmail(User.FindFirstValue(ClaimTypes.Name)).Result.role.roleName;

            User res = _AppFunctions.GetUserByEmail(logedIn).Result;
            if (res != null)
            {
                return View();

            }

            ///need verif log_page
            return RedirectToAction("Erreur404");


        }

        public ActionResult ShowUsers()
        {
            List<User> agentsList = _AdminFunctions.ShowAgents().Result ;
            if (agentsList == null)
            {
                //rederect to erreur page for case erreur
                return RedirectToAction("Erreur404", "Home");

            }
            ViewBag.agentsList = agentsList;

            return View();


        }

        public IActionResult AddUser()
        {
            return View();
        }



        public IActionResult EditAgentPermission(string mail)
        {
            List<Permission> a = _AppFunctions.getUserPermissions(mail);
            ViewBag.AgentPermission = a;

            ViewBag.Permissions = _AppFunctions.ShowAllPermissions();

            User c = (User)_AppFunctions.GetUserByEmail(mail).Result;

            return View(c);

        }

        public async Task<IActionResult> validatePermissions()
        {

            string a = Request.Form["AreChecked"];
            var numbers = a.Split(',').Select(Int32.Parse).ToList();

            int b = Int16.Parse(Request.Form["agentID"]);
            await _AdminFunctions.changePermissions(numbers, b);

            if (_AdminFunctions.changePermissions(numbers, b).Result)

            {


                //need to figure this out 
                //string mail = Request.Form["agentMail"];
                // return RedirectToAction("EditAgentPermission", "Admin",p1.Email);

                //temporary solution
                return RedirectToAction("ShowUsers", "Admin");
            }

            //need errer page for baseErreur

            return RedirectToAction("DashBoardAdmin", "Admin");
        }


        [HttpPost]
        
        public IActionResult settings(User _p)
        {
            try
            {


                User p1 = new Userservice().updateInfo(_p).Result;

                if (p1 != null)
                {


                    //need to figure this out 
                    // return RedirectToAction("EditAgentPermission", "Admin",p1.Email);

                    //temporary solution
                    return RedirectToAction("ShowUsers", "Admin");
                }
                else
                {
                    System.Diagnostics.Debug.WriteLine("problem in the admin controller");
                    return RedirectToAction("Error404");
                }



            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e);
                return RedirectToAction("Error404");
            }


        }


        public ActionResult customersList()
        {
          List<Client> res = _AdminFunctions.getAllCustomers().Result;
            return View(res);

        }

        [HttpGet]
        public ActionResult addAgent()
        {

            //getting role List
            ViewBag.RoleList = new SelectList(_AppFunctions.getRolesForAgents(),"roleId","roleName");
            return View();

        }

        [HttpPost]
        public ActionResult addAgent(Agent agent)
        {

            //getting role List
            if (_AdminFunctions.addAgent(agent).Result !=null) return RedirectToAction("DashBoardAdmin", "Admin");
            return View();

        }


        public ActionResult afectProduct(string clientMail)
        {
            ViewBag.ClientEmail = clientMail;
            ViewBag.ListProducts = _AppFunctions.getAllProducts(); 
            return PartialView("afectProduct");
        }



        public ActionResult afectTheProduct(string client,string refProd)
        {
            if (_AppFunctions.addProductClient(refProd, client).Result)
            {
                return RedirectToAction("customersList", "Admin");

            }
            return RedirectToAction("Erreur404", "Home");
        }
    }
}
