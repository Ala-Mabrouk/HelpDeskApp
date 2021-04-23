using AppFeatures;
using Entities.Entities;
using HelpDesk.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using static Entities.Entities.Ticket;

namespace HelpDesk.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        //creation of instance from AppFeatures

        private readonly ClientService _ClientCRUD = new ClientService();
        private readonly PersonService _PersonService = new PersonService();
        private readonly AppFunctions _AppFunctions = new AppFunctions();




        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;



        }

        public IActionResult Index()
        {

            return View();

        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Sign_Up(Client _cl)
        {

            if (ModelState.IsValid)
            {
                Client cl1 = (Client)_ClientCRUD.SignUp(_cl);

                if (cl1 != null)
                {
                    HttpContext.Session.SetInt32("userID", cl1.Id);
                    return RedirectToAction("Index", "Home");
                }

            }


            return RedirectToAction("Erreur", "Home");



        }


        [HttpPost]
        public IActionResult Log_in(Person pers)

        {
            Person test = _PersonService.LogIn(pers.Email, pers.Password);
            if (test != null)
            {
                HttpContext.Session.SetInt32("userID", test.Id);
                HttpContext.Session.SetString("userRole", test.role.roleName);



                if (test.role.roleName.Equals("Client"))
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    return RedirectToAction("DashBoardAdmin", "Admin");

                }

            }

            return RedirectToAction("Index", "Home");
        }




        public IActionResult log_out()
        {

            HttpContext.Session.Remove("userID");
            HttpContext.Session.Remove("userRole");

            return RedirectToAction("Index", "Home");


        }



    }
}

