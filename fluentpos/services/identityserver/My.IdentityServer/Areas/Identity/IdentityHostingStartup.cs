using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(My.IdentityServer.Areas.Identity.IdentityHostingStartup))]
namespace My.IdentityServer.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
        }
    }
}