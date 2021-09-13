using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Modul4HW6.DataAccess;
using Modul4HW6.Services;
using Modul4HW6.Services.Abstractions;

namespace Modul4HW6
{
    public class Starter
    {
        private IAppConfigService _config;

        public Starter(
            IAppConfigService configService)
        {
            _config = configService;
        }

        public void Run()
        {
            var dbOptions = new DbContextOptionsBuilder<Modul4HW6DBContext>().UseSqlServer(_config.ConnectionString);
            using var dbContext = new Modul4HW6DBContext(dbOptions.Options);

            var newList = dbContext.Artists;
        }
    }
}
