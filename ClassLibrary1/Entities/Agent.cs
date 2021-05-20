﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Entities
{
    public class Agent:User
    {

        [Display(Name = "Status", ResourceType = typeof(Ressources.Ressource_Person.Resource))]
        public string status { get; set; }

        public ICollection<A_T_Managment> a_T_ManagmentsList { get; set; }

    }
}
