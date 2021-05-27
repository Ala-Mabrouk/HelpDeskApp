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

       

        private readonly AppFunctions _AppFunctions = new AppFunctions();


        //for getUserPermissions from the tables

        private readonly AdminServices _AdminFunctions = new AdminServices();

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

        public ActionResult ShowAgents()
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


        [HttpGet]
        public IActionResult EditAgentPermission(string mail)
        {
            Agent ag = (Agent) _AppFunctions.GetUserByEmail(mail).Result;

            return View(ag);

        }

        public async Task<IActionResult> validatePermissions()
        {



            //think about the opposit side (SALIM IDEA)

            string a = Request.Form["AreChecked"];

            var numbers = a.Split(',').Select(Int32.Parse).ToList();

            int b = Int16.Parse(Request.Form["agentID"]);

          Boolean test= await _AdminFunctions.changePermissions(numbers, b);

            if (test)

            {
                  string agmail = Request.Form["agentMail"];
                 return RedirectToAction("EditAgentPermission", "Admin",new { mail = agmail });
 
            }

            //need errer page for baseErreur

            return RedirectToAction("DashBoardAdmin", "Admin");
        }


        [HttpPost]
        
        public IActionResult updateAgentPersInfo(Agent _p)
        {
            try
            {
                string test = Request.Form["AgentStatus"];

                if (test == "true")
                {
                    _p.status = true;
                }
                else
                {
                    _p.status = false;
                }

                Agent ag1 = new Userservices().updateAgentInfo(_p).Result;

                if (ag1 != null)
                {


                     return RedirectToAction("EditAgentPermission", "Admin",new { mail = ag1.Email });

                   
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

           
            if (_AdminFunctions.addAgent(agent).Result !=null) return RedirectToAction("ShowAgents", "Admin");

            return RedirectToAction("Erreur404","Home");

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



        public ActionResult clientDetails(string mailClient)
        {


            var res = _AppFunctions.GetUserByEmail(mailClient).Result;
            var res2 = _AppFunctions.getClientProducts(res.Id);
            var res3 = _AppFunctions.getTicketsByUser(res.Id).Result;

            ViewBag.clientDetails = res;
            ViewBag.clientProducts = res2;
            ViewBag.clientTickets = res3;

            return View();


        }

        [HttpPost]
        //used to change selected agent password
        public IActionResult changeAgentPassword(Agent a)
        {

             
/*            string oldpass = Request.Form["Id"];
*/            string newpass = Request.Form["newPass"];
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
                    return RedirectToAction("EditAgentPermission", "Admin",new { mail = a.Email });

                }
            }
            return RedirectToAction("Erreur404", "Home");

        }







    }
}
