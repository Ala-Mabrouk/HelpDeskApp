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

namespace HelpDesk.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        //private readonly IHttpContextAccessor httpContextAccessor;


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
            ViewBag.LatestProduct = _AppFunctions.getLatestProducts().Result;
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


        [HttpGet]
        public IActionResult Sign_Up()
        {
            return View();
        }

        [HttpPost]

        public ActionResult Sign_Up(Client _cl)
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

                    HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);

                    logedIn = User.FindFirstValue(ClaimTypes.Name);

                    return RedirectToAction("Index", "Home");
                }
                ModelState.AddModelError("", "Unable to sign up for now!try later ");

            }

            return View(_cl);

        }

        [HttpGet]
        public IActionResult Log_in()
        {
            return View();
        }

        [HttpPost]

        public async Task<IActionResult> Log_in(LogUser pers, string ReturnUrl)

        {
            if (ModelState.IsValid)
            {
                User test = _UserService.LogIn(pers.Email, pers.Password).Result;

                if (test != null)
                {
                    var identity = new ClaimsIdentity(new[] {

                    new Claim(ClaimTypes.Name, test.Email),
                    new Claim(ClaimTypes.Role,test.role.roleName)

                    }, CookieAuthenticationDefaults.AuthenticationScheme);


                    var principal = new ClaimsPrincipal(identity);


                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);


                    if (test.role.roleName.Equals("Client"))
                    {
                        if (string.IsNullOrEmpty(ReturnUrl))
                        {
                            return RedirectToAction("Index", "Home");

                        }
                        else
                        {
                            return Redirect(ReturnUrl);
                        }

                    }
                    else
                    {
                        return RedirectToAction("DashBoardAdmin", "Admin");

                    }

                }

                ModelState.AddModelError("", "User not Found");

            }

            return View(pers);


        }
       
        [HttpGet]
        public ActionResult ResetPassword()
        {
            return View();
        }


        [HttpPost]
        public ActionResult ResetPassword(string email)
        {
            //send reclamation to Admin to give back new pass
            if (_AppFunctions.resetPass(email))
            {
                RedirectToAction("Index", "Home");
            }
            return View();
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
            User pers = _AppFunctions.GetUserByEmail(logedIn).Result;

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

            if (newpass != confirmPass && !_UserService.changeUserPassword(logedIn, oldpass, newpass).Result)
            {
                ViewBag.erreurChanging = "no changes have been made ";
                return RedirectToAction("Erreur404", "Home");
            }
            else
            {
                return RedirectToAction("settings", "Home");

            }
            
        }


    }
}

