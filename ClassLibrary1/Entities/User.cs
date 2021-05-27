using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Entities
{
   public class User

    {
 
        [Key]
        public int Id { get; set; }


        [Display(Name = "FirstName", ResourceType = typeof(Ressources.Ressource_Person.Resource))]
        [Required(ErrorMessageResourceType = typeof(Ressources.Ressource_Person.Resource), ErrorMessageResourceName = "FirstNameRequired")]
        public string FirstName { get; set; }

        [Display(Name = "LastName", ResourceType = typeof(Ressources.Ressource_Person.Resource))]
        [Required(ErrorMessageResourceType = typeof(Ressources.Ressource_Person.Resource), ErrorMessageResourceName = "LastNameRequired")]
        public string LastName { get; set; }

        [Display(Name = "Email", ResourceType = typeof(Ressources.Ressource_Person.Resource))]
        [Required(ErrorMessageResourceType = typeof(Ressources.Ressource_Person.Resource), ErrorMessageResourceName = "EmailRequired")]
        [RegularExpression(@"^([0-9a-zA-Z]([\+\-_\.][0-9a-zA-Z]+)*)+@(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]*\.)+[a-zA-Z0-9]{2,3})$",
            ErrorMessageResourceType = typeof(Ressources.Ressource_Person.Resource), ErrorMessageResourceName = "EmailInvalid")]
        public string Email { get; set; }


        [Display(Name = "Password", ResourceType = typeof(Ressources.Ressource_Person.Resource))]
        [Required(ErrorMessageResourceType = typeof(Ressources.Ressource_Person.Resource), ErrorMessageResourceName = "PasswordRequired")]
        [RegularExpression(@"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{4,25}$",
          ErrorMessageResourceType = typeof(Ressources.Ressource_Person.Resource), ErrorMessageResourceName = "PasswordInvalid")]
        public string Password { get; set; }



        [Display(Name = "Phone", ResourceType = typeof(Ressources.Ressource_Person.Resource))]
        [Required(ErrorMessageResourceType = typeof(Ressources.Ressource_Person.Resource), ErrorMessageResourceName = "PhnRequired")]
        [RegularExpression(@"^([0-9]{8})$", ErrorMessageResourceType = typeof(Ressources.Ressource_Person.Resource), ErrorMessageResourceName = "PhnRange")]
        public string Phone { get; set; }


        [Display(Name = "Home_adresse", ResourceType = typeof(Ressources.Ressource_Person.Resource))]
        public string HomeAdresse { get; set; }


        public string ThumbUrl { get; set; } = "~/Content/images/p_placeholder.png";

        [NotMapped]
        public IFormFile userImageFile { get; set; }

        public int roleId { get; set; }

        public Role role { get; set; }

        //LIST OF USER PERMISSION
        public ICollection<UserPermission> listUserPermissions { get; set; }

        //List of created tickets 

        public ICollection<Ticket> listTickets { get; set; }


       


    }


}
 
