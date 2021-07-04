using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Entities
{
    public class Product
    {
        [Key]
        [Display(Name = "Ref", ResourceType = typeof(Ressources.Ressource_Product.Resource))]
        [Required(ErrorMessageResourceType = typeof(Ressources.Ressource_Product.Resource), ErrorMessageResourceName = "RefRequired")]

        public string refId { get; set; }

        [Display(Name = "ProductName", ResourceType = typeof(Ressources.Ressource_Product.Resource))]
        [Required(ErrorMessageResourceType = typeof(Ressources.Ressource_Product.Resource), ErrorMessageResourceName = "ProductNameRequired")]
        public string name { get; set; }

        [Display(Name = "Description", ResourceType = typeof(Ressources.Ressource_Product.Resource))]
        [Required(ErrorMessageResourceType = typeof(Ressources.Ressource_Product.Resource), ErrorMessageResourceName = "DescriptionRequired")]
        public string description { get; set; }

        [Display(Name = "FactoryName", ResourceType = typeof(Ressources.Ressource_Product.Resource))]
        [Required(ErrorMessageResourceType = typeof(Ressources.Ressource_Product.Resource), ErrorMessageResourceName = "FactroyNameRequired")]
        public string factoryName { get; set; }

        [Display(Name = "BuildDate", ResourceType = typeof(Ressources.Ressource_Product.Resource))]
        public DateTime dateBuild { get; set; }

        [Display(Name = "ValidationDate", ResourceType = typeof(Ressources.Ressource_Product.Resource))]
        public DateTime dateValidate { get; set; } 

        [Display(Name = "Category", ResourceType = typeof(Ressources.Ressource_Product.Resource))]
 //       public string category { get; set; }
        public string imgUrl { get; set; } = "~/Content/images/placeholder_0.png";

        [Display(Name = "price", ResourceType = typeof(Ressources.Ressource_Product.Resource))]
        public  double price { get; set; } = 0.0;

        [Display(Name = "addedDate", ResourceType = typeof(Ressources.Ressource_Product.Resource))]
        public DateTime addedDate { get; set; } = DateTime.Now;
        [NotMapped]
        public IFormFile ImageFile { get; set; }

        public int categoryID { get; set; }

        public Category productCategory { get; set; }

        //List Clients 

        public ICollection<ProductClient> ListProductClient { get; set; }


    }
}
