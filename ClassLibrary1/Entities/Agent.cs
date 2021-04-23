using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Entities
{
    public class Agent:Person
    {

        [Display(Name = "Status", ResourceType = typeof(Ressources.Ressource_Person.Resource))]
        public string status { get; set; }

    }
}
