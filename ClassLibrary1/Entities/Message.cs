using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Entities
{
   public class Message
    {

        [Key]
        public int msgID { get; set; }
        public int senderId { get; set; }
        public int reciverId { get; set; }
        public string msgContent { get; set; }
        public DateTime msgDate { get; set; }

 
        public Message()
        {

        }
        public Message(int sender,int reciver,string msg,DateTime msgdate)
        {
            this.senderId = sender;
            this.reciverId = reciver;
            this.msgContent = msg;
            this.msgDate = msgdate;
        }

    }
}
