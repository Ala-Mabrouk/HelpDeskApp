using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Entities
{
    public class DefaultPermissions
    {
      
        public Role role { get; set; }
        [Key, Column(Order = 0)]
        public int roleId { get; set; }

        public Permission permission { get; set; }

        [Key, Column(Order = 1)]
        public int permissionId { get; set; }





    }
}
