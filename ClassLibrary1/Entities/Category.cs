using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Entities
{
   public class Category
    {
        [Key]
        public int categoryId { get; set; }
        public string categoryName { get; set; }
        public string categoryDescription { get; set; }

        //List of product 
        public List<Product> listProduct { get; set; }

        //List of articles
        public List<Article> listArtiles { get; set; }

    }
}
