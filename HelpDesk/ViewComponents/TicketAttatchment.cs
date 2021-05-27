using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace HelpDesk.ViewComponents
{
    public class TicketAttatchment : ViewComponent
    {
        public  IViewComponentResult Invoke(string filePath)
        {


            try
            {
                FileInfo fi = new FileInfo(filePath);

                ViewBag.fileSize = (decimal)fi.Length / 1000000;
                ViewBag.fileName = fi.Name.Substring(fi.Name.LastIndexOf("-") + 1);
            }catch(Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e);
                return null;
            }

            return View();





        }
    }
}
