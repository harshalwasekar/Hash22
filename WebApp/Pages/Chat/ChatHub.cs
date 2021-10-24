using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp.Pages.Chat
{
    public class ChatHub : Hub
    {
        //static List<Users> ConnectedUsers = new List<Users>();
        //static List<Messages> CurrentMessage = new List<Messages>();
        //ConnClass ConnC = new ConnClass();

        public void Connect(string userName)
        {
            var id = Context.ConnectionId;

            //if (ConnectedUsers.Count(x => x.ConnectionId == id) == 0)
            //{
            //    string UserImg = GetUserImage(userName);
            //    string logintime = DateTime.Now.ToString();
            //    ConnectedUsers.Add(new Users { ConnectionId = id, UserName = userName, UserImage = UserImg, LoginTime = logintime });

            //    // send to caller  
            //    Clients.Caller.onConnected(id, userName, ConnectedUsers, CurrentMessage);

            //    // send to all except caller client  
            //    Clients.AllExcept(id).onNewUserConnected(id, userName, UserImg, logintime);
            //}
        }
    }
}