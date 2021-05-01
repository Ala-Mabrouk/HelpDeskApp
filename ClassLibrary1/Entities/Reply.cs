using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Entities
{
   public  class Reply
    {

        public int replyId { get; set; }
        public Ticket ticket { get; set; }
        public Agent r_agent { get; set; }
        public string content { get; set; }
        public DateTime reply_date { get; set; }




    }
}
