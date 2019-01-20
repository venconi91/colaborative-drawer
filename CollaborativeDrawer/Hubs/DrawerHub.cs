using CollaborativeDrawer.DrawerModels;
using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace CollaborativeDrawer.Hubs
{
  public class DrawerHub : Hub
  {
    public async Task SendCommand(DrawCommand command)
    {
      await Clients.Others.SendAsync("Draw", command);
    }
  }
}
