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
        public string Title { get; set; }
        public string content { get; set; }
        //  public string category { get; set; }
        public int categoryId { get; set; }
        public Category articleCategory { get; set; }
        public int creator_agentId { get; set; }
        public Agent creator_agent { get; set; }

        public DateTime creationDate { get; set; } = DateTime.Now;
        public DateTime lastModified { get; set; } = DateTime.Now;





    }
}
