using Entities.DashBoardModels;
using Entities.Entities;
using Entity_DAL.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
 

namespace AppFeatures
{
   public class DashBoardServices
    {
        public DataBaseContext _context =  new DataBaseContext(DataBaseContext.ops.dbOptions);
        public DashBoardModel _dashBoardModel = new DashBoardModel();

        public DashBoardModel affectResults()
        {
            //pie Model

            //getting all tickets nb;
         var nbTotaleOfTickets = _context.Tickets.Where(t => t.ticketDate > new DateTime(2021, 1, 1, 00, 00, 00)).Count();
            //get the nb of tickets by status

            var nbOpenedTicket = _context.Tickets.Where(t => t.ticketStatut == Entities.Entities.Ticket.TicketStatus.Open).Count();
            var nbProccessingTicket =_context.Tickets.Where(t => t.ticketStatut == Entities.Entities.Ticket.TicketStatus.Distributed).Count();

            //getting all the ticket of this year
            List<Ticket> allTickets = _context.Tickets.Where(t => t.ticketDate > new DateTime(2021, 1, 1, 00, 00, 00)).ToList();




            _dashBoardModel.nbTicketByStatus = allTickets.GroupBy(t => t.ticketDate).Select(t => new PieChartData(t.Key.ToString(), t.Count() * 100 / (decimal)nbTotaleOfTickets)).ToList();

           //_dashBoardModel.evolutionOfTicketsNbByMonths= allTickets.GroupBy(t => t.ticketDate).Select(t => new LineChartData(DateTime.Parse(t.Key.ToString()), t.Count())).ToList();



            return _dashBoardModel;

        }



    }
}
