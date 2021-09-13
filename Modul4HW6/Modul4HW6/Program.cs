using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Modul4HW6.DataAccess;
using Modul4HW6.Services;
using Modul4HW6.Services.Abstractions;

namespace Modul4HW6
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
                .AddTransient<Starter>()
                .AddTransient<IAppConfigService, AppConfigService>()
                .BuildServiceProvider();

            var starter = serviceProvider.GetService<Starter>();
            starter.Run();
        }
    }
}
