using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Entities
{

    public class Knowledge_base
    {

        public int fqaId { get; set; }

        public string title { get; set; }

        public string question { get; set; }

        public DateTime creationDate { get; set; }
        public DateTime lastModified { get; set; }
        //public Category category { get; set; }
    }
}
