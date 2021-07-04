using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HelpDesk.Models
{
    public class PaymentCard
    {
        [Display(Name = "nameOnCard", ResourceType = typeof(Ressources.Ressource_Card.Resource))]
        [Required(ErrorMessageResourceType = typeof(Ressources.Ressource_Card.Resource), ErrorMessageResourceName = "nameOnCardRequied")]
        /* [RegularExpression(@"^[A-Za-z]\\w{2, 29}$",
             ErrorMessageResourceType = typeof(Ressources.Ressource_Card.Resource), ErrorMessageResourceName = "nameOnCardInvalid")]
 */
        public string nameOnCard { get; set; }


        [Display(Name = "cardNumber", ResourceType = typeof(Ressources.Ressource_Card.Resource))]
        [Required(ErrorMessageResourceType = typeof(Ressources.Ressource_Card.Resource), ErrorMessageResourceName = "cardNumberRequied")]
        public string cardNumber { get; set; }



        [Display(Name = "email", ResourceType = typeof(Ressources.Ressource_Card.Resource))]
        [Required(ErrorMessageResourceType = typeof(Ressources.Ressource_Card.Resource), ErrorMessageResourceName = "emailRequied")]
        [RegularExpression(@"^([0-9a-zA-Z]([\+\-_\.][0-9a-zA-Z]+)*)+@(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]*\.)+[a-zA-Z0-9]{2,3})$",
            ErrorMessageResourceType = typeof(Ressources.Ressource_Card.Resource), ErrorMessageResourceName = "EmailInvalid")]
        public string email { get; set; }


        [Display(Name = "firstName", ResourceType = typeof(Ressources.Ressource_Card.Resource))]
        [Required(ErrorMessageResourceType = typeof(Ressources.Ressource_Card.Resource), ErrorMessageResourceName = "firstNameRequied")]
        /* [RegularExpression(@"^[A-Za-z]\\w{2, 29}$",
             ErrorMessageResourceType = typeof(Ressources.Ressource_Card.Resource), ErrorMessageResourceName = "firstNameInvalid")]
 */
        public string firstName { get; set; }


        [Display(Name = "lastName", ResourceType = typeof(Ressources.Ressource_Card.Resource))]
        [Required(ErrorMessageResourceType = typeof(Ressources.Ressource_Card.Resource), ErrorMessageResourceName = "lastNameRequied")]
        /*  [RegularExpression(@"^[A-Za-z]\\w{2, 29}$",
              ErrorMessageResourceType = typeof(Ressources.Ressource_Card.Resource), ErrorMessageResourceName = "lastNameInvalid")]
  */
        public string lastName { get; set; }


        [Display(Name = "cvvNumber", ResourceType = typeof(Ressources.Ressource_Card.Resource))]
        [Required(ErrorMessageResourceType = typeof(Ressources.Ressource_Card.Resource), ErrorMessageResourceName = "cvvNumberRequied")]
        /*  [RegularExpression(@"^[0-9]{3, 4}$",
              ErrorMessageResourceType = typeof(Ressources.Ressource_Card.Resource), ErrorMessageResourceName = "cvvNumberInvalid")]
  */
        public string cvvNumber { get; set; }


    }
}
