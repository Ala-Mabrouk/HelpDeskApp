using AppFeatures;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace HelpDesk
{
    public class ChatHub : Hub
    {

        public static AppFunctions _appFunctions = new AppFunctions();

        public override Task OnConnectedAsync()
        {
            //save my cnx id in table

           _appFunctions.saveCnxId(Context.ConnectionId, Context.User.FindFirstValue(ClaimTypes.Name));


            return base.OnConnectedAsync();
        }

        /*  public async Task SendMessage(string user, string message)
          {
              await Clients.All.SendAsync("ReceiveMessage", user, message);
          }*/

        public async Task SendToUser(string sender, string reciver, string message)
        {



            //getting the cnxId of the wanted user
            var id = _appFunctions.GetUserByEmail(reciver).Result.Id;

            var reciverCnxId = new AppFunctions().getCnxId(id).Result;

            //getting sender entity
            var se = _appFunctions.GetUserByEmail(sender).Result;

            //saving message data in database

           await _appFunctions.saveMessage(se.Id, id, message, DateTime.Now);

            string imgurl = se.ThumbUrl.Replace("~/", "C:/Users/worrior107/source/repos/HelpDeskApp/HelpDesk/wwwroot/");
            await Clients.Client(reciverCnxId).SendAsync("ReceiveMessage", se.Email,se.FirstName,imgurl, message);

        }

        public string GetConnectionId() => Context.ConnectionId;




    }
}
