using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SamSystemWeb.Data;
using SamSystemWeb.Models;

[assembly: HostingStartup(typeof(SamSystemWeb.Areas.Identity.IdentityHostingStartup))]
namespace SamSystemWeb.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<DataContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("DataContextConnection")));

                services.AddDefaultIdentity<AppUser>()
                    .AddEntityFrameworkStores<DataContext>();
            });
        }
    }
}