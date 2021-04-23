using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Entities
{
   public  class Role
    {

        [Key]
        public int roleId { get; set; }

        [Display(Name = "Role", ResourceType = typeof(Ressources.Ressource_Person.Resource))]
        public string roleName { get; set; }

       
        //list of person
        public ICollection<Person> listPerson { get; set; }

        //list of default permissions
        public ICollection<DefaultPermissions>  listDefaultPermissions { get; set; }
       






    }
}
