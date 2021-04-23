using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Entities
{
    public class Client :Person
    {
        [Display(Name = "Priority", ResourceType = typeof(Ressources.Ressource_Person.Resource))]
        public int priority { get; set; }

    }
}
