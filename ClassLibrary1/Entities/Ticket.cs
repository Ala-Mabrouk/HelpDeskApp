using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Entities.Entities; 

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


        [Display(Name = "ticketID", ResourceType = typeof(Ressources.Ressource_Tickets.ResourceTicket))]
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

        public string uploadedFile { get; set; } = null;

        [NotMapped]
        public IFormFile uploadedFileFile { get; set; }

        public int userId { get; set; }

        public User creator_user { get; set; }

        public string relatedProductRefId { get; set; }
        public Product relatedProduct { get; set; }

        public ICollection<A_T_Managment> listAT_Management { get; set; }

        //ticket replys
        public ICollection<Reply> ListOfReplies { get; set; }


    }
}
