using AppFeatures;
using Entities.Entities;
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
            loged = verifLog();
            if (loged > 0)
            {
                getUsertickets();
                return View();
            }

            return RedirectToAction("Erreur404", "Home");
        }

        [HttpGet]
        public IActionResult addTicket()
        {

            int log = verifLog();
            System.Diagnostics.Debug.WriteLine("th logged value" + log);

            List<Product> res = _AppFunctions.getClientProducts(log);


            if (res == null)
            {
                return RedirectToAction("Erreur404", "Home");
            }


            ViewBag.ClientProducts = res;
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> addTicket(Ticket ticket)
        {
            loged = verifLog();
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

                    await _UserService.createTicket(ticket);

                    return RedirectToAction("Index", "Tickets");
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("", "Unable to add Ticket for now");
                }
            }

            /*    List<Product> res = _AppFunctions.getClientProducts(loged);
                ViewBag.ClientProducts = res;
                return View("addTicket",ticket);*/


            return RedirectToAction("Erreur404", "Home");
        }



        [HttpGet]
        public IActionResult addTicket_Backoffice(string ClientMail)
        {

            ViewBag.userMail = ClientMail;
            return View();

            System.Diagnostics.Debug.WriteLine("in the get methode mail is: " + ClientMail);
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


              var res=  _AppFunctions.addProductClient(ticket.relatedProductRefId, mail).Result;

                ticket.userId = ClientId;
                ticket.ticketPriority = TicketPriority.Medium;
                ticket.ticketStatut = TicketStatus.Distributed;
                ticket.ticketDate = DateTime.Now;


                await _UserService.createTicket(ticket);




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



    public ActionResult closeTicket(int ticketId)
        {
           if( _AppFunctions.closeTicket(ticketId).Result){
                return RedirectToAction("Index"); }
            return RedirectToAction("Erreur404", "Home");
        }








        public void getUsertickets()
        {


            ViewBag.MyTickets = _AppFunctions.getTicketsByUser(loged).Result;


        }
        public IActionResult listTickets()
        {
            List<Ticket> list = _AppFunctions.showAllTickets().Result;
            ViewBag.ListTickets = list;
            return View();
        }

        public IActionResult singleTicketInfo(int ticketid)
        {
            Ticket ticket = _AppFunctions.ticketInfo(ticketid).Result;

            var replies = _AppFunctions.getTicketReplies(ticketid).Result;

            ViewBag.ticketReplies = replies;


            ViewBag.Ticket = ticket;

            return View();
        }


        public int verifLog()
        {
            int id = _AppFunctions.GetUserByEmail(User.FindFirstValue(ClaimTypes.Name)).Result.Id;
            return id;

        }
        public ActionResult ticketInfo(int idTicket)
        {


            var res = _AppFunctions.ticketInfo(idTicket).Result;
            var replies = _AppFunctions.getTicketReplies(idTicket).Result;


            /*            replies.First().replyOwner.role.roleName
            */
            ViewBag.Ticket = res;
            ViewBag.ticketReplies = replies;

            System.Diagnostics.Debug.WriteLine("i am in the ticket info action");

            return PartialView("ticketInfo");
        }

        public ActionResult ticketDetailInfo(int idTicket)
        {

            var res = _AppFunctions.getTicketDetails(idTicket).Result;

            System.Diagnostics.Debug.WriteLine("i am in the ticket detail  info action");

            return PartialView("ticketDetailInfo", res);
        }

        [HttpPost]
        public ActionResult addReply(Reply reply)
        {


            string D_action = Request.Form["asp-action"];
            string D_controller = Request.Form["asp-controller"];
            string email = Request.Form["replierAdress"];

            int replierId = _AppFunctions.GetUserByEmail(email).Result.Id;



            reply.replyOwnerId = replierId;

            reply.reply_date = DateTime.Now;

            var res = _AppFunctions.addReply(reply).Result;
            if (res != null)
            {
                var res2 = _AppFunctions.changeTicketStatus(res.TicketId, TicketStatus.Proccesing);
            }

            return RedirectToAction(D_action, D_controller);
        }
    }
}
