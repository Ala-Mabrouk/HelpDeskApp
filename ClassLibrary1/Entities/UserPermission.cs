using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Entities
{


    //THIS CLASS IS A ASSOSIAED CLASS OF PERSONS AND PERMISIONS TABLES 

    public class UserPermission
    {
 
       
        public User user { get; set; }
        [Key, Column(Order = 0)]
        public int userId { get; set; }

        public Permission permision { get; set; }
        [Key, Column(Order = 1)]
        public int permisionId { get; set; }

    }
}
