using AppFeatures;
using Entities.Entities;
using Entity_DAL.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelpDesk.Controllers
{
    public class SuperAdmincontroller : Controller
    {


        private readonly AppFunctions _AppFunctions = new AppFunctions();
        private readonly SuperAdminServices _SuperAdminServices = new SuperAdminServices();
        private static DataBaseContext _context = new DataBaseContext(DataBaseContext.ops.dbOptions);


        public IActionResult Index()
        {
            return View();
        }




        public ActionResult ShowAdmins()
        {
            List<Admin> agentsList = _SuperAdminServices.ShowAdmins().Result;
            if (agentsList == null)
            {
                //rederect to erreur page for case erreur
                return RedirectToAction("Erreur404", "Home");

            }
            ViewBag.agentsList = agentsList;

            return View();


        }

        [HttpGet]
        public ActionResult addAdmin()
        {
            return View();
        }


        [HttpPost]
        [HttpPost]
        public ActionResult addAdmin(Admin admin)
        {


            if (_SuperAdminServices.addAdmin(admin).Result != null) return RedirectToAction("ShowAdmins", "SuperAdmin");

            return RedirectToAction("Erreur404", "Home");




        }

        [HttpGet]
        public ActionResult updateAdmin(string mailAdmin)
        {
            Admin ad = (Admin)_AppFunctions.GetUserByEmail(mailAdmin).Result;

            return PartialView("updateAdmin",ad);

        }


        [HttpPost]
        public ActionResult updateAdmin(Admin _admin)
        {
            try
            {
                string test = Request.Form["AgentStatus"];

                if (test == "true")
                {
                    _admin.status = true;
                }
                else
                {
                    _admin.status = false;
                }


                Admin ad = (Admin)new Userservices().updateAgentInfo(_admin).Result;

                if (ad != null)
                {


                    return RedirectToAction("ShowAdmins", "SuperAdmin");


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


        [HttpPost]
        public IActionResult changeAdminPassword(Admin a)
        {


           
            string newpass = Request.Form["newPass"];
            string confirmPass = Request.Form["confirmNewPass"];
            if (newpass.Equals(confirmPass))
            {

                if (!_SuperAdminServices.changeAgentPassword(a.Email, newpass).Result)
                {
                    ViewBag.erreurChanging = "no changes have been made ";
                    return RedirectToAction("Erreur404", "Home");
                }
                else
                {
                    return RedirectToAction("updateAdmin", "SuperAdmin", new { mailAdmin = a.Email });

                }
            }
            return RedirectToAction("Erreur404", "Home");

        }



    }
}