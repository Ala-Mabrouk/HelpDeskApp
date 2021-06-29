using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Entities
{
    public class cnxEntity
    {

        [Key]
        public int id { get; set; }
        public int idUser { get; set; }
        public string cnxId { get; set; }

        public cnxEntity(int idUser,string idcnx)
        {
            this.idUser = idUser;
            this.cnxId = idcnx;
        }
        public cnxEntity()
        {

        }
    }
}
