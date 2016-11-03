using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class MyHub : Hub
    {
        public void Sync(string msg)
        {
            Clients.All.Sync(msg);
        }
    }
}