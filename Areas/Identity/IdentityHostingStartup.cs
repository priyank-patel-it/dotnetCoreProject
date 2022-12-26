using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PWSched_dotnet_mvc.Data;


[assembly: HostingStartup(typeof(PWSched_dotnet_mvc.Areas.Identity.IdentityHostingStartup))]
namespace PWSched_dotnet_mvc.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
            });

            
        }
    }
}