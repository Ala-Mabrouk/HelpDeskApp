using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Entities
{
    public class Client :User
    {
        [Display(Name = "Priority", ResourceType = typeof(Ressources.Ressource_Person.Resource))]
        public int priority { get; set; } = 1;




        //List of Products
        public ICollection<ProductClient> myListProducts { get; set; }

    }
}
