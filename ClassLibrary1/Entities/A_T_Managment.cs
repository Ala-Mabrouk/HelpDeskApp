using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Entities
{
    public class A_T_Managment
    {
        [Key, Column(Order = 0)]
        public int agentId { get; set; }
        public Agent agent { get; set; }

        [Key, Column(Order = 1)]
        public int ticketId { get; set; }
        public Ticket ticket { get; set; }

        public DateTime dateAssign { get; set; }



    }
}
