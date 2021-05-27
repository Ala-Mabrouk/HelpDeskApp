using AppFeatures;
using Entities.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelpDesk.ViewComponents
{
    public class UpdateUserpassword : ViewComponent
    {
        public IViewComponentResult Invoke(string mail)
        {
            Agent res = (Agent)new AppFunctions().GetUserByEmail(mail).Result;
            return View(res);
        }

    }
}
