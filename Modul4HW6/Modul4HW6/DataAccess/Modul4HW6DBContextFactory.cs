using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using Modul4HW6.Services;

namespace Modul4HW6.DataAccess
{
    public class Modul4HW6DBContextFactory : IDesignTimeDbContextFactory<Modul4HW6DBContext>
    {
        private AppConfigService _config = new AppConfigService();

        public Modul4HW6DBContext CreateDbContext(string[] args)
        {
            var dbContextOption = new DbContextOptionsBuilder<Modul4HW6DBContext>();
            dbContextOption.UseSqlServer(_config.ConnectionString);
            return new Modul4HW6DBContext(dbContextOption.Options);
        }
    }
}
