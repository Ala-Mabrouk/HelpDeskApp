using AppFeatures;
using Entities.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace HelpDesk.Controllers
{
    public class AgentController : Controller
    {


        private readonly AppFunctions _AppFunctions = new AppFunctions();
        private readonly AgentServices _AgentServices = new AgentServices();




        public IActionResult Index()
        {
            return View();
        }




        public ActionResult getTicket(int IdTicket)
        {


            if (_AppFunctions.workOnTicket("agent4@agent4.com", IdTicket))
            {
                return RedirectToAction("listTickets", "Tickets");
            }
            else { return RedirectToAction("Erreur404", "Home"); }
        }

        public ActionResult myTickets()
        {
            ViewBag.ListTickets = _AppFunctions.getAgentTickets("agent4@agent4.com");
            return View();
        }


      

        [HttpGet]
        [Authorize]
        public IActionResult AgentSettings()
        {
            var logedIn = User.FindFirstValue(ClaimTypes.Name);
            User pers = _AppFunctions.GetUserByEmail(logedIn).Result;

            if (pers == null)
            {
                return RedirectToAction("Erreur404", "Home");
            }
            return View(pers);
        }

       
        [HttpPost]
        [Authorize]
        public IActionResult AgentSettings([FromForm] Agent _p)
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
       
      
        public ActionResult changeMyAgentPassword()
        {

           var logedIn = User.FindFirstValue(ClaimTypes.Name);

            string oldpass = Request.Form["oldPass"];
            string newpass = Request.Form["newPass"];
            string confirmPass = Request.Form["confirmPass"];

            if (newpass != confirmPass || !_AgentServices.changeUserPassword(logedIn, oldpass, newpass).Result)
            {
                ViewBag.erreurChanging = "no changes have been made ";
                return RedirectToAction("Erreur404", "Home");
            }
            else
            {
                return RedirectToAction("AgentSettings", "Agent");

            }




        }


    }
}
