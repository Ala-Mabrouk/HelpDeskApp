 using AppFeatures;
using Entities.Entities;
using HelpDesk.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace HelpDesk.Controllers
{
    public class AdminController : Controller
    {


        //creation of instance from AppFeatures.ClientCRUD

        private readonly ClientService _ClientCRUD = new ClientService();
        private readonly AppFunctions _AppFunctions = new AppFunctions();

        //for getUserPermissions from the tables

        private readonly AdminService _AdminFunctions = new AdminService();




        public IActionResult DashBoardAdmin()

        {
            int a = (int)HttpContext.Session.GetInt32("userID");

            Person res = _AppFunctions.GetUserById(a);
            if (res != null)
            {
                return View();

            }
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });


        }

        public ActionResult ShowUsers()
        {
            List<Person> agentsList = _AdminFunctions.ShowAgents();
            ViewBag.agentsList = agentsList;

            return View();


        }

        public IActionResult AddUser()
        {
            return View();
        }



        public IActionResult EditAgentPermission(int id)
        {
            List<Permission> a = _AppFunctions.getUserPermissions(id);
            ViewBag.ClientPermission = a;

            ViewBag.Permissions = _AppFunctions.ShowAllPermissions();

            Client c = (Client)_AppFunctions.GetUserById(id);

            return View(c);

        }

        public IActionResult validatePermissions()
        {

            string a = Request.Form["AreChecked"];
            var numbers = a.Split(',').Select(Int32.Parse).ToList();

            int b = Int16.Parse(Request.Form["agentID"]);

            _AdminFunctions.changePermissions(numbers, b);

            return RedirectToAction("DashBoardAdmin", "Admin");
        }



    }
}
