using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Entities
{
    public class Permission
    {

        [Key]
        public int permissionId { get; set; }
        public string permissionName { get; set; }
        public string permissionDescription { get; set; }

        //list for the default permissions

        public ICollection<DefaultPermissions> listDefaultPermissions { get; set; }

        public ICollection<UserPermission> listUserPermissions { get; set; }



    }
}
