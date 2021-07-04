using AppFeatures;
using Entities.Entities;
using HelpDesk.Models;
using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
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

        private readonly ClientServices _ClientCRUD = new ClientServices();
        private readonly Userservices _UserService = new Userservices();
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
                    return RedirectToAction("DashBoardAdmin", "Agent");
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
        public IActionResult Sign_Up(Client _cl)
        {
            if (ModelState.IsValid)
            {

                Client cl1 = (Client)_UserService.SignUp(_cl).Result;

                if (cl1 != null)
                {
                    //Create the identity for the user 
                    var identity = new ClaimsIdentity(new[] {
                    new Claim(ClaimTypes.Name, cl1.Email),
                    new Claim(ClaimTypes.Role,cl1.role.roleName)
                }, CookieAuthenticationDefaults.AuthenticationScheme);

                    var principal = new ClaimsPrincipal(identity);

                    HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);

                    /*                    logedIn = User.FindFirstValue(ClaimTypes.Name);
                    */
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
                User myUser = _UserService.LogIn(pers.Email, pers.Password).Result;

                if (myUser != null)
                {
                    var identity = new ClaimsIdentity(new[] {

                    new Claim(ClaimTypes.Name, myUser.Email),
                    new Claim(ClaimTypes.Role,myUser.role.roleName)

                    }, CookieAuthenticationDefaults.AuthenticationScheme);


                    var principal = new ClaimsPrincipal(identity);


                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);


                    if (myUser.role.roleName.Equals("Client"))
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
                         
                        Agent a = (Agent)myUser;
                        if (a!=null && a.status)
                         return RedirectToAction("DashBoardAdmin", "Agent");

                        //used to delete the cookies bc the agent is not activated 
                        var login = HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);


                    }

                }

                ModelState.AddModelError("", "user not found or not active !! ");

            }

            return View(pers);


        }

     
        [HttpGet]
        public ActionResult ResetPassword()
        {
            return View();
        }

 

        [HttpPost]
        public ActionResult ResetPassword(string msg)
        {
            string phone = Request.Form["phoneNumber"];
            string mail = Request.Form["emailAdress"];

            if (_AppFunctions.resetPassword(mail,phone).Result)
            {
                return RedirectToAction("Log_in", "Home");
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
        [Authorize(Roles = "Client")]
        public IActionResult settings()
        {
            logedIn = User.FindFirstValue(ClaimTypes.Name);
            User pers = _AppFunctions.GetUserByEmail(logedIn).Result;

            if (pers == null)
            {
                return RedirectToAction("Erreur404", "Home");
            }
            return View(pers);
        }

        [HttpPost]
        [Authorize(Roles = "Client")]
        public IActionResult settings([FromForm] User _p)
        {

            try
            {
                if (_p.userImageFile != null)
                {
                    var imgFile = _p.userImageFile;


                    string FileName = Path.GetFileNameWithoutExtension(imgFile.FileName);

                    //To Get File Extension  
                    string FileExtension = Path.GetExtension(imgFile.FileName);

                    //Add Current Date To Attached File Name  
                    FileName = FileName.Trim() + FileExtension;

                    //Get Upload path from Web.Config file AppSettings.  
                    string UploadPath = "C:\\Users\\worrior107\\source\\repos\\HelpDeskApp\\HelpDesk\\wwwroot\\ProfileImges\\";

                    string contentPath = "~/ProfileImges/";
                    //Its Create complete path to store in server.

                    string completPath = UploadPath + FileName;
                    _p.ThumbUrl = contentPath + FileName;

                    //save file in the uploadPath 

                    using (var stream = new FileStream(completPath, FileMode.Create))
                    {
                        imgFile.CopyTo(stream);

                    }
                }

                User p1 = new Userservices().updateInfo(_p).Result;

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
                return RedirectToAction("Erreur404");
            }


        }


        public IActionResult HelpCenter()
        {
            return View();
        }


        [Authorize(Roles = "Client")]
        public IActionResult changePassword()
        {
            logedIn = User.FindFirstValue(ClaimTypes.Name);

            string oldpass = Request.Form["oldPass"];
            string newpass = Request.Form["newPass"];
            string confirmPass = Request.Form["confirmPass"];

            if (newpass != confirmPass || !_UserService.changeUserPassword(logedIn, oldpass, newpass).Result)
            {
                ViewBag.erreurChanging = "no changes have been made ";
                return RedirectToAction("Erreur404", "Home");
            }
            else
            {
                return RedirectToAction("settings", "Home");

            }

        }

        [HttpPost]
        public ActionResult resultRech()
        {

            string res = Request.Form["inputRech"];
            ViewBag.resultProducts = _AppFunctions.findProduct(res).Result;
            ViewBag.resultArticles = _AppFunctions.findArticles(res).Result;

            return View();



        }
 

 
    }
}

