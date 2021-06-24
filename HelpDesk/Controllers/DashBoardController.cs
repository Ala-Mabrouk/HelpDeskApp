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
            //  _dashboardService.affectResults();
            return View();
        }

        [HttpGet]
        public IActionResult getPie()
        {


            //   ViewBag.Data = "Value,Value1,Value2,Value3"; //list of strings that you need to show on the chart. as mentioned in the example from c-sharpcorner
            // ViewBag.ObjectName = "Test,Test1,Test2,Test3";





            DashBoardModel res = _dashboardService.affectResults();
            foreach (var item in res.evolutionOfTicketsNbByMonths)
            {
                System.Diagnostics.Debug.Write(item.X + " "+item.Y);
                System.Diagnostics.Debug.WriteLine("");
               




            }
             return View(res);
            // return Ok(this._dashboardService.affectResults());
        }


    }
}
