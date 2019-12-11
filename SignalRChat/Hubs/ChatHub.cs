using Common.ChatSignalRNetCoreWebAppli.Models;
using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace SignalRChat.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }

        public async Task SendMessagePrivate(string user, string to, string message)
        {
            await Clients.All.SendAsync("ReceiveMessagePrivate", user, to, message);
        }

        public async Task SendMessageServer(EmployeeInfo user, string to, MsEvent message)
        {
            await Clients.All.SendAsync("ReceiveMessageServer", user, to, message);
        }

    }
}