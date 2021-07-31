using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HelpDesk.Models
{
    public class LogUser
    {

        [Display(Name = "Email", ResourceType = typeof(Ressources.Ressource_Person.Resource))]
        [Required(ErrorMessageResourceType = typeof(Ressources.Ressource_Person.Resource), ErrorMessageResourceName = "EmailRequired")]
        [RegularExpression(@"^([0-9a-zA-Z]([\+\-_\.][0-9a-zA-Z]+)*)+@(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]*\.)+[a-zA-Z0-9]{2,3})$",
            ErrorMessageResourceType = typeof(Ressources.Ressource_Person.Resource), ErrorMessageResourceName = "EmailInvalid")]
        public string Email { get; set; }

        [Display(Name = "Password", ResourceType = typeof(Ressources.Ressource_Person.Resource))]
        [Required(ErrorMessageResourceType = typeof(Ressources.Ressource_Person.Resource), ErrorMessageResourceName = "PasswordRequired")]
        public string Password { get; set; }

     


    }
}
