using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Entities
{
    public class Article
    {
        [Key]
        public int ArticleId { get; set; }



        [Display(Name = "Title", ResourceType = typeof(Ressources.Ressource_Article.Resource))]
        [Required(ErrorMessageResourceType = typeof(Ressources.Ressource_Article.Resource), ErrorMessageResourceName = "TitleRequired")]
        public string Title { get; set; }

        [Display(Name = "content", ResourceType = typeof(Ressources.Ressource_Article.Resource))]
        [Required(ErrorMessageResourceType = typeof(Ressources.Ressource_Article.Resource), ErrorMessageResourceName = "contentRequired")]
        public string content { get; set; }
        
        public int categoryId { get; set; }
        public Category articleCategory { get; set; }
        
        public int creator_agentId { get; set; }
        
        public Agent creator_agent { get; set; }

        
        public DateTime creationDate { get; set; } = DateTime.Now;
        
        public DateTime lastModified { get; set; } = DateTime.Now;





    }
}
