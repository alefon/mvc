using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace mvc
{
    [HubName("chatHub")]
    public class ChatHub : Hub
    {
        //Este lo vamos para ver que los usuarios estén conectados
        //public override System.Threading.Tasks.Task OnConnected()
        //{
        //    Clients.All.user(Context.User.Identity.Name);
        //    return base.OnConnected();
        //}

        public void send(string name , string message)
        {
            Clients.Caller.message("Yo: " + message);
            Clients.Others.message(name + " : " + message);
        }

    }
}