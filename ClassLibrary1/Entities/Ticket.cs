using System;
using System.ComponentModel.DataAnnotations;

namespace Entities.Entities
{
    public class Ticket
    {

        // Enumeration for ticket status
        public enum TicketStatus
        {
            Open = 1,
            Distributed = 2,
            Proccesing = 3,
            Checking = 4,
            Closed = 5
        }
        // Enumeration for ticket priority
        public enum TicketPriority
        {
            Low = 1,
            Medium = 2,
            High = 3,
            Critical = 4
        }



        public int ticketId { get; set; }

        [Required(ErrorMessageResourceType = typeof(Ressources.Ressource_Tickets.ResourceTicket), ErrorMessageResourceName = "ticketTitleRequired")]
        [Display(Name = "ticketTitle", ResourceType = typeof(Ressources.Ressource_Tickets.ResourceTicket))]
        public string ticketTitle { get; set; }

        [Required(ErrorMessageResourceType = typeof(Ressources.Ressource_Tickets.ResourceTicket), ErrorMessageResourceName = "ticketDescriptionRequired")]
        [Display(Name = "ticketDescription", ResourceType = typeof(Ressources.Ressource_Tickets.ResourceTicket))]
        public string ticketDescription { get; set; }

        [Display(Name = "ticketStatut", ResourceType = typeof(Ressources.Ressource_Tickets.ResourceTicket))]
        public TicketStatus ticketStatut { get; set; } = TicketStatus.Distributed;


        [Display(Name = "ticketType", ResourceType = typeof(Ressources.Ressource_Tickets.ResourceTicket))]
        public string ticketType { get; set; }


        [Display(Name = "ticketPriority", ResourceType = typeof(Ressources.Ressource_Tickets.ResourceTicket))]
        public TicketPriority ticketPriority { get; set; }

        [Display(Name = "ticketDate", ResourceType = typeof(Ressources.Ressource_Tickets.ResourceTicket))]
        public DateTime ticketDate { get; set; }

        

        public int personId { get; set; }

        public Person c_person { get; set; }




    }
}
