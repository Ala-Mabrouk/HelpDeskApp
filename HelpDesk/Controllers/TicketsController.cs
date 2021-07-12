using AppFeatures;
using Entities.Entities;
using HelpDesk.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

using static Entities.Entities.Ticket;

namespace HelpDesk.Controllers
{
    [Authorize]
    public class TicketsController : Controller
    {

        private readonly Userservices _UserService = new Userservices();
        private readonly AppFunctions _AppFunctions = new AppFunctions();

        private static int loged;




        public IActionResult Index()
        {
            int loged = _AppFunctions.GetUserByEmail(User.FindFirstValue(ClaimTypes.Name)).Result.Id;
            ViewBag.MyTickets = _AppFunctions.getTicketsByUser(loged).Result.OrderByDescending(t=>t.ticketDate);
            return View();
            

           
        }

        [HttpGet]
        public IActionResult addTicket()
        {

            int log = _AppFunctions.GetUserByEmail(User.FindFirstValue(ClaimTypes.Name)).Result.Id;


            List<Product> res = _AppFunctions.getClientProducts(log);

            ViewBag.ClientProducts = res;
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> addTicket(Ticket ticket)
        {
            loged = _AppFunctions.GetUserByEmail(User.FindFirstValue(ClaimTypes.Name)).Result.Id;

            // in case if a modale is invalid 
            List<Product> res = _AppFunctions.getClientProducts(loged);

            ViewBag.ClientProducts = res;


            if (ModelState.IsValid)
            {
                try
                {
                    if (ticket.uploadedFileFile != null)
                    {
                        var imgFile = ticket.uploadedFileFile;


                        string FileName = Path.GetFileNameWithoutExtension(imgFile.FileName);

                        //To Get File Extension  
                        string FileExtension = Path.GetExtension(imgFile.FileName);

                        //Add Current Date-ownerID-productId  To Attached File Name  
                        FileName = DateTime.Now.ToString("yyyyMMdd") + "-" + loged + "-" + ticket.relatedProductRefId + "-" + FileName.Trim() + FileExtension;


                        string UploadPath = "C:\\Users\\worrior107\\source\\repos\\HelpDeskApp\\HelpDesk\\wwwroot\\uploads\\";

                        string contentPath = "wwwroot/uploads/";
                        //Its Create complete path to store in server.

                        string completUploadPath = UploadPath + FileName;

                        ticket.uploadedFile = contentPath + FileName;

                        //save file in the uploadPath 

                        using (var stream = new FileStream(completUploadPath, FileMode.Create))
                        {
                            imgFile.CopyTo(stream);

                        }

                    }


                    //traitement d ajout du ticket
                    ticket.ticketPriority = TicketPriority.Medium;
                    ticket.ticketStatut = TicketStatus.Distributed;
                    ticket.ticketDate = DateTime.Now;
                    ticket.userId = loged;


                    //case no product is selected 
                    if (ticket.relatedProductRefId == null)
                    {
                        ModelState.AddModelError("", "Need to select a product");
                        return View(ticket);
                    }


                    if (await _AppFunctions.addTicket(ticket) != null)
                    {
                        ResultOperation result = new ResultOperation();



                        result.statusOp = true;
                        result.message = "Done!";                    

                        ViewBag.Message = result;

                        ViewBag.MyTickets = _AppFunctions.getTicketsByUser(loged).Result.OrderByDescending(t => t.ticketDate);
                        return View("Index");
               
                    }
                    ModelState.AddModelError("", "Unable to submit ticket for now");

                }
                catch (Exception e)
                {
                    return RedirectToAction("Erreur404", "Home");
                }
            }

            return View(ticket);
        }



        [HttpGet]
        public IActionResult addTicket_Backoffice(string ClientMail)
        {

            ViewBag.userMail = ClientMail;
            return View();

        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> addTicket_Backoffice(Ticket ticket)
        {

            /* if (ModelState.IsValid)
             {*/


            try
            {
                if (ticket.uploadedFileFile != null)
                {
                    var imgFile = ticket.uploadedFileFile;


                    string FileName = Path.GetFileNameWithoutExtension(imgFile.FileName);

                    //To Get File Extension  
                    string FileExtension = Path.GetExtension(imgFile.FileName);

                    //Add Current Date-ownerID-productId  To Attached File Name  
                    FileName = DateTime.Now.ToString("yyyyMMdd") + "-" + ticket.userId + "-" + ticket.relatedProductRefId + "-" + FileName.Trim() + FileExtension;


                    string UploadPath = "C:\\Users\\worrior107\\source\\repos\\HelpDeskApp\\HelpDesk\\wwwroot\\uploads\\";

                    string contentPath = "wwwroot/uploads/";
                    //Its Create complete path to store in server.

                    string completUploadPath = UploadPath + FileName;

                    ticket.uploadedFile = contentPath + FileName;

                    //save file in the uploadPath 

                    using (var stream = new FileStream(completUploadPath, FileMode.Create))
                    {
                        imgFile.CopyTo(stream);

                    }

                }



                //traitement d ajout du ticket

                //get Client Email
                string mail = Request.Form["UserMail"];


                int ClientId = _AppFunctions.GetUserByEmail(mail).Result.Id;


                var res = _AppFunctions.addProductClient(ticket.relatedProductRefId, mail).Result;

                ticket.userId = ClientId;
                ticket.ticketPriority = TicketPriority.Medium;
                ticket.ticketStatut = TicketStatus.Distributed;
                ticket.ticketDate = DateTime.Now;


                await _AppFunctions.addTicket(ticket);




                return RedirectToAction("clientDetails", "Admin", new { mailClient = mail });
            }
            catch (Exception e)
            {
                ModelState.AddModelError("", "Unable to add Ticket for now");
            }
            //   }

            /*    List<Product> res = _AppFunctions.getClientProducts(loged);
                ViewBag.ClientProducts = res;
                return View("addTicket",ticket);*/


            return RedirectToAction("Erreur404", "Home");
        }


        [HttpGet]
        public ActionResult closeTicket(int ticketId)

        {
            System.Diagnostics.Debug.WriteLine(ticketId);
            var res = _AppFunctions.getTicketDetails(ticketId).Result;



            return PartialView("closeTicket", res);
        }



        public ActionResult close(Ticket t)

        {
            int id = Int16.Parse(Request.Form["ticketId"]);
            if (_AppFunctions.closeTicket(id).Result)
            {
                return RedirectToAction("Index", "Tickets");
            }
            return RedirectToAction("Erreur404", "Home");
        }

 
        public IActionResult listTickets()
        {
            List<Ticket> list = _AppFunctions.showAllTickets().Result;
            ViewBag.ListTickets = list;
            ViewBag.loger = User.FindFirstValue(ClaimTypes.Role);
            return View();
        }
        public IActionResult FULlistTickets()
        {
            List<Ticket> list = _AppFunctions.showAllSystemTickets().Result;
            ViewBag.ListTickets = list;
            ViewBag.loger = User.FindFirstValue(ClaimTypes.Role);
            return View("listTickets");
        }

        public IActionResult singleTicketInfo(int ticketid)
        {
            Ticket ticket = _AppFunctions.ticketInfo(ticketid).Result;

            var replies = _AppFunctions.getTicketReplies(ticketid).Result;

            if (replies.Count > 0)
            {
                ViewBag.ticketReplies = replies;
            }
 
            ViewBag.Ticket = ticket;
            if (replies != null)
            {
                foreach (var item in replies)
                {
                    ViewBag.recivermail = item.replyOwner.Email;
                    break;
                }
            }

            return View();
        }

        public ActionResult ticketInfo(int idTicket)
        {


            var res = _AppFunctions.ticketInfo(idTicket).Result;
            var replies = _AppFunctions.getTicketReplies(idTicket).Result;

            ViewBag.Ticket = res;
            ViewBag.ticketReplies = replies;

            System.Diagnostics.Debug.WriteLine("i am in the ticket info action");

            return PartialView("ticketInfo");
        }

        public ActionResult ticketDetailInfo(int idTicket)
        {

            var res = _AppFunctions.getTicketDetails(idTicket).Result;

            var agent = _AppFunctions.GetUserByEmail(User.FindFirstValue(ClaimTypes.Name)).Result;

            ViewBag.Permission = false;
            //getting agent's permissions name
            foreach (var item in agent.listUserPermissions)
            {
                if (item.permision.permissionName == "Assign tickets")
                {
                    ViewBag.Permission = true;
                    break;
                }

            }

            return PartialView("ticketDetailInfo", res);
        }

        [HttpPost]
        public async Task<ActionResult> addReply(Reply reply)
        {


            string D_action = Request.Form["asp-action"];
            string D_controller = Request.Form["asp-controller"];
            string email = Request.Form["replierAdress"];

            int replierId = _AppFunctions.GetUserByEmail(email).Result.Id;



            reply.replyOwnerId = replierId;

            reply.reply_date = DateTime.Now;

            // saving file if exist

            if (reply.r_uploadedFileFile != null)
            {
                var imgFile = reply.r_uploadedFileFile;


                string FileName = Path.GetFileNameWithoutExtension(imgFile.FileName);

                //To Get File Extension  
                string FileExtension = Path.GetExtension(imgFile.FileName);

                //Add Current Date-ownerID-ticketID  To Attached File Name  
                FileName = DateTime.Now.ToString("yyyyMMdd") + "-" + loged + "-" + reply.TicketId + "-" + FileName.Trim() + FileExtension;


                string UploadPath = "C:\\Users\\worrior107\\source\\repos\\HelpDeskApp\\HelpDesk\\wwwroot\\uploads\\";

                string contentPath = "wwwroot/uploads/";
                //Its Create complete path to store in server.

                string completUploadPath = UploadPath + FileName;

                reply.r_uploadedFile = contentPath + FileName;

                //save file in the uploadPath 

                using (var stream = new FileStream(completUploadPath, FileMode.Create))
                {
                    imgFile.CopyTo(stream);

                }

            }


            var res = _AppFunctions.addReply(reply).Result;
            if (res != null)
            {
                var res2 = _AppFunctions.changeTicketStatus(res.TicketId, TicketStatus.Proccesing);
            }

            // notification treatement 


            //send notification from agent to client
            if (D_action == "myTickets")
            {

                //send reply notification from agent to client

                string to = Request.Form["destination"];

                await _AppFunctions.sendClientNotification(to, res.ticket.ticketTitle, res.TicketId, res.reply_date);
                return RedirectToAction(D_action, D_controller);
            }

            return RedirectToAction(D_action, D_controller, new { ticketid = res.TicketId });

        }



    }
}
