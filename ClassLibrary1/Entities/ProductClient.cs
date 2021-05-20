using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Entities
{
    public class ProductClient
    {



        [Key, Column(Order = 0)]
        public int clientId { get; set; }
        public Client client { get; set; }

        [Key, Column(Order = 1)]
        public string refId { get; set; }
        public Product product { get; set; }
        public DateTime date { get; set; }
        public int quantity { get; set; } = 1;


    }
}
