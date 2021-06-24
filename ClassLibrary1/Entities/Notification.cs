using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Entities
{
    public class Notification
    {
        [Key]
        public int notificationID { get; set; }
        public int senderNotification { get; set; }
        public int reciverNotification { get; set; }

        public string notificationContent { get; set; }
        public DateTime notificationDate { get; set; }

    }
}
