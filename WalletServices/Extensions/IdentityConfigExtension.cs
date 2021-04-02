using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using WalletServices.Data;
using WalletServices.Models;

namespace WalletServices.Extensions
{
    public static class IdentityConfigExtension
    {
        /// <summary>
        /// configures the Identity provider
        /// </summary>
        /// <param name="services"></param>
        public static void AddIdentityConfiguring(this IServiceCollection services)
        {
            services.AddIdentity<User, IdentityRole>().AddEntityFrameworkStores<DataContext>()
                .AddDefaultTokenProviders();
            services.Configure<IdentityOptions>(o =>
            {
                o.Password.RequireDigit = false;
                o.Password.RequireLowercase = false;
                o.Password.RequiredLength = 6;
            });
        }
    }
}
