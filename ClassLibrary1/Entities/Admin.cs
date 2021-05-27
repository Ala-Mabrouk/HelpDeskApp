using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Entities
{
   public  class Admin:Agent
    {
        public DateTime affectingDate { get; set; } = DateTime.Now;
    }
}
