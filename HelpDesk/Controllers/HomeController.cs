using AppFeatures;
using Entities.Entities;
using HelpDesk.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading;
using System.Threading.Tasks;
using static Entities.Entities.Ticket;

namespace HelpDesk.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IHttpContextAccessor httpContextAccessor;

        //creation of instance from AppFeatures

        private readonly ClientService _ClientCRUD = new ClientService();
        private readonly Userservice _UserService = new Userservice();
        private readonly AppFunctions _AppFunctions = new AppFunctions();

        private static string logedIn = "";




        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            @ViewData["Title"] = "HELPDESK APP";
            if (User.Identity.IsAuthenticated)
            {
                logedIn = User.FindFirstValue(ClaimTypes.Name);
                if (!User.FindFirstValue(ClaimTypes.Role).Equals("Client"))
                {
                    return RedirectToAction("DashBoardAdmin", "Admin");
                }
            
            }
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
        [AllowAnonymous]
        public ActionResult Sign_Up(Client _cl)
        {
            try
            {
                if (ModelState.IsValid)
                {

                    Client cl1 = (Client)_ClientCRUD.SignUp(_cl).Result;

                    if (cl1 != null)
                    {
                        //Create the identity for the user 
                        var identity = new ClaimsIdentity(new[] {
                    new Claim(ClaimTypes.Name, cl1.Email),
                    new Claim(ClaimTypes.Role,cl1.role.roleName)
                }, CookieAuthenticationDefaults.AuthenticationScheme);

                        var principal = new ClaimsPrincipal(identity);

                        var login =  HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);
                        logedIn = User.FindFirstValue(ClaimTypes.Name);
 
                        return RedirectToAction("Index", "Home");
                    }

                }


            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e);
            }
            return RedirectToAction("Error404");



        }

        
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Log_in(User pers)

        {
            User test = _UserService.LogIn(pers.Email, pers.Password).Result;
     
            if (test != null)
            {

  
                var identity = new ClaimsIdentity(new[] {
                    new Claim(ClaimTypes.Name, test.Email),
                    new Claim(ClaimTypes.Role,test.role.roleName)
                }, CookieAuthenticationDefaults.AuthenticationScheme);


                var principal = new ClaimsPrincipal(identity);
              

                await  HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme
                    , principal
                   );
 

                if (test.role.roleName.Equals("Client"))
                {
                    
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    return RedirectToAction("DashBoardAdmin", "Admin");

                }

            }
            //need to be changed to logerreur page

            return RedirectToAction("Index", "Home");
        }


        public IActionResult log_out()
        {
            var login = HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
   

            return RedirectToAction("Index", "Home");

        }

        public IActionResult Erreur404()
        {
            return View();
        }
        [HttpGet]
        [Authorize]
        public IActionResult settings()
        {
            System.Diagnostics.Debug.WriteLine("***********"+logedIn);
             User  pers =  _AppFunctions.GetUserByEmail(logedIn).Result;

            if (pers == null)
            {
                return RedirectToAction("Erreur404", "Home");
            }
            return View(pers);
        }

        [HttpPost]
        [Authorize]
        public IActionResult settings(User _p)
        {
            try
            {
                User p1 = new Userservice().updateInfo(_p).Result;

                if (p1 != null)
                {

                    return View(p1);
                }
                else
                {
                    ViewBag.erreurChanging = "no changes have vbeen made ";

                    return RedirectToAction("settings", "Home");
                }



            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e);
                return RedirectToAction("Error404");
            }


        }

        public IActionResult HelpCenter()
        {
            return View();
        }


        [Authorize]
        public IActionResult changePassword()
        {
             string oldpass = Request.Form["oldPass"];
            string newpass = Request.Form["newPass"];
            string confirmPass = Request.Form["confirmPass"];

            if (newpass!=confirmPass && !_UserService.changeUserPassword(logedIn, oldpass, newpass).Result)

                ViewBag.erreurChanging = "no changes have been made ";


            return RedirectToAction("settings", "Home");
        }
    }
}

