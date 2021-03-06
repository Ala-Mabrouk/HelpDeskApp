using AppFeatures;
using Entities.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
 
using static Entities.Entities.Ticket;

namespace HelpDesk.Controllers
{
    
    public class TicketsController : Controller
    {

        private readonly PersonService _PersonService = new PersonService();
        private readonly AppFunctions _AppFunctions = new AppFunctions();
        public IActionResult Index()
        {
            getUsertickets();

            return View();
        }

        [HttpGet]
        public IActionResult addTicket()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult addTicket(Ticket ticket)
        {
            if (true)
            {
                if (ModelState.IsValid)
                {
                    //traitement d ajout du ticket
                    ticket.ticketPriority = TicketPriority.Medium;
                    ticket.ticketStatut = TicketStatus.Distributed;
                    ticket.ticketDate = DateTime.Now;
                    ticket.personId = (int)HttpContext.Session.GetInt32("userId");

                    
                    _PersonService.createTicket(ticket);

                }

                RedirectToAction("listTickets", "Tickets");

            }

            return RedirectToAction("Index", "Home");



        }


        public void getUsertickets()
        {
            int userid = (int)HttpContext.Session.GetInt32("userID");
            ViewBag.MyTickets = _AppFunctions.getTicketsByUser(userid);



        }
        public IActionResult listTickets()
        {
            int a= (int)HttpContext.Session.GetInt32("userId");
            List<Ticket> list = _AppFunctions.showAllTickets(a);
            ViewBag.ListTickets = list;
            return View();
        }

        public IActionResult singleTicketInfo(int ticketid)
        {
            Ticket ticket = _AppFunctions.ticketInfo(ticketid);
            ViewBag.Ticket = ticket;

            return View();
        }


        public int verifLog()
        {

            return (int)HttpContext.Session.GetInt32("userId");

        }

    }
}
