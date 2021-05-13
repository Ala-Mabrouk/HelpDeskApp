using AppFeatures;
using Entities.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
 
using static Entities.Entities.Ticket;

namespace HelpDesk.Controllers
{
    [Authorize]
    public class TicketsController : Controller
    {

        private readonly Userservice _UserService = new Userservice();
        private readonly AppFunctions _AppFunctions = new AppFunctions();

        private static int loged;

        public IActionResult Index()
        {
            loged = verifLog();
            if (loged > 0) {
                getUsertickets();
            return View(); }

           return RedirectToAction("Erreur404", "Home");
        }

        [HttpGet]
        public IActionResult addTicket()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> addTicket(Ticket ticket)
        {
            
            if (loged>0)
            {
                if (ModelState.IsValid)
                {
                    //traitement d ajout du ticket
                    ticket.ticketPriority = TicketPriority.Medium;
                    ticket.ticketStatut = TicketStatus.Distributed;
                    ticket.ticketDate = DateTime.Now;
                    ticket.userId = loged;

                    await _UserService.createTicket(ticket);

                }

               return RedirectToAction("Index", "Tickets");

            }

            return RedirectToAction("Erreur404", "Home");



        }


        public void getUsertickets()
        {

            
            ViewBag.MyTickets = _AppFunctions.getTicketsByUser(loged).Result;
        

        }
        public IActionResult listTickets()
        { 
            List<Ticket> list = _AppFunctions.showAllTickets(loged).Result;
            ViewBag.ListTickets = list;
            return View();
        }

        public IActionResult singleTicketInfo(int ticketid)
        {
            Ticket ticket = _AppFunctions.ticketInfo(ticketid).Result;
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

            ViewBag.Ticket = res;
            return View();
        }

    }
}
