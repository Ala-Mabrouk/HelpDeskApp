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

    [Authorize]
    public class AgentController : Controller
    {



        private static string logedIn;
        private static string roleIn;

        private readonly AppFunctions _AppFunctions = new AppFunctions();
        private readonly AgentServices _AgentServices = new AgentServices();




        public IActionResult Index()
        {
            return View();
        }




        public IActionResult DashBoardAdmin()

        {

            logedIn = _AppFunctions.GetUserByEmail(User.FindFirstValue(ClaimTypes.Name)).Result.Email;
            roleIn = _AppFunctions.GetUserByEmail(User.FindFirstValue(ClaimTypes.Name)).Result.role.roleName;

            User res = _AppFunctions.GetUserByEmail(logedIn).Result;
            if (res != null)
            {
                return RedirectToAction("Index", "DashBoard");

            }

            ///need verif log_page
            return RedirectToAction("Erreur404");


        }




        //******* Manage Clients *******
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


        [HttpGet]
        public ActionResult addClient()
        {
            return PartialView();
        }

        [HttpPost]
        public ActionResult addClient(Client c)
        {

            var res = new Userservices().SignUp(c).Result;
            if (res != null)
                return RedirectToAction("customersList");

            return RedirectToAction("Erreur404", "Home");

        }


        public ActionResult customersList()
        {
            List<Client> res = _AgentServices.getAllCustomers().Result;
            return View(res);

        }



        //********* tickets manipulation *******

        [HttpGet]
        public ActionResult assignTicket(int ticketId)
        {
            var logedIn = User.FindFirstValue(ClaimTypes.Name);

            var res = _AppFunctions.getTicketDetails(ticketId).Result;

            var me = (Agent)_AppFunctions.GetUserByEmail(logedIn).Result;

             List<Agent> listAgents = new AdminServices().ShowAgents().Result;
            List<Agent> listAgents2 = new List<Agent>();

            foreach (var item in listAgents)
            {
                if (item.Email != me.Email && item.status ) //for only the active agents
                {
                    listAgents2.Add(item);
                }

            }
 
            ViewBag.AgentList = listAgents2;

            return View(res);
 

        }

        [HttpPost]
        public ActionResult assignTicket()
        {
            int ticketID = Int16.Parse(Request.Form["ticketId"]);
            int AgentId = Int16.Parse(Request.Form["AgentId"]);
            int idAgentAssigner = _AppFunctions.GetUserByEmail(User.FindFirstValue(ClaimTypes.Name)).Result.Id;

            if (_AppFunctions.assignTicket(ticketID, AgentId))
            {

                Notification n = new Notification();
                n.reciverNotification = AgentId;
                n.senderNotification = idAgentAssigner;
                n.notificationContent = "the ticket <a href='https://localhost:44330/Agent/customersList'>#" + ticketID + "</a> is assigned to you by " + User.FindFirstValue(ClaimTypes.Name) + "";
                n.notificationDate = DateTime.Now;
                _AppFunctions.createNotificationAssignTicket(n);
                return RedirectToAction("listTickets", "Tickets");
            }


            return RedirectToAction("Erreur404", "Home");
        }

        public ActionResult myTickets()
        {
            var logedIn = User.FindFirstValue(ClaimTypes.Name);
            ViewBag.ListTickets = _AppFunctions.getAgentTickets(logedIn);
            return View();
        }

        //add a ticket to myTickets list from all ticketsList
        public ActionResult getTicket(int IdTicket)
        {
            var logedIn = User.FindFirstValue(ClaimTypes.Name);

            if (_AppFunctions.workOnTicket(logedIn, IdTicket))
            {
                return RedirectToAction("listTickets", "Tickets");
            }
            else { return RedirectToAction("Erreur404", "Home"); }
        }

        





            //******* agent profil management *********
        [HttpGet]   
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


        //********* products Manipulation *************

        public ActionResult afectProduct(string clientMail)
        {
            ViewBag.ClientEmail = clientMail;
            ViewBag.ListProducts = _AppFunctions.getAllProducts();

            ViewBag.Categories = _AppFunctions.getcategories().Result;
            return PartialView("afectProduct");
        }

        public IActionResult afectTheProduct(string client, string refProd)
        {
            System.Diagnostics.Debug.WriteLine("le client est: " + client + "le product is: " + refProd);

            if (_AppFunctions.addProductClient(refProd, client).Result)
            {
                return RedirectToAction("customersList");
            }

            return RedirectToAction("Erreur404", "Home");
        }

    }
}
