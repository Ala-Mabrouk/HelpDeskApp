using AppFeatures;
using Entities.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace HelpDesk.Controllers
{
    public class chatController : Controller
    {
        public IActionResult Index()
        {


            int logerId = new AppFunctions().GetUserByEmail(User.FindFirstValue(ClaimTypes.Name)).Result.Id;

            ViewBag.conv = getConversation(33, 35);
            ViewBag.logeduser = logerId; 
            return View();
        }

        [HttpPost]
        public void saveMessage()
        {
            string sender = Request.Form["sender"];
            string msg = Request.Form["message"];

            System.Diagnostics.Debug.WriteLine("the msg from "+sender+" is: "+msg);
        }

       public List<Message> getConversation(int pers1,int pers2)
        {
           var res =  new AppFunctions().getCoversation(pers1, pers2).Result;
            return res;
        }
    }
}
