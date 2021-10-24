using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(WebApp.Pages.Chat.Startup))]
namespace WebApp.Pages.Chat
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}