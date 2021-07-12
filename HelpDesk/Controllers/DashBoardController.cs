using AppFeatures;
using Entities.DashBoardModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelpDesk.Controllers
{
    public class DashBoardController : Controller
    {
        private readonly DashBoardServices _dashboardService = new DashBoardServices();

        public IActionResult Index()
        {
            DashBoardModel res = _dashboardService.affectResults();

            return View(res);
        }

 

    }
}
