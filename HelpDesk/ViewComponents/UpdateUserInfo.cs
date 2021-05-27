using AppFeatures;
using Entities.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelpDesk.ViewComponents
{
    public class UpdateUserInfo : ViewComponent
    {
        public IViewComponentResult Invoke(string pers)
        {
            Agent res =(Agent) new AppFunctions().GetUserByEmail(pers).Result;
            return View(res);
        }

    }
}
