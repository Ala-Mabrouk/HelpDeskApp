using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Entities
{
   public  class Reply
    {
        public int replyId { get; set; }

        //the related ticket
        public int TicketId { get; set; }
        public Ticket ticket { get; set; }

        //owners of the reply
        public int replyOwnerId { get; set; }
        public User replyOwner { get; set;}

        public string content { get; set; }
        public DateTime reply_date { get; set; }

        public string r_uploadedFile { get; set; } = null;

    }
}
