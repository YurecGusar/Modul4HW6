using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using Modul4HW6.Configs;
using Modul4HW6.Services.Abstractions;

namespace Modul4HW6.Services
{
    public class AppConfigService : IAppConfigService
    {
        private const string _path = "config.json";
        public AppConfigService()
        {
            var config = GetAppConfig();
            ConnectionString = config.ConnectionString;
        }

        public string ConnectionString { get; }

        private AppConfig GetAppConfig()
        {
            var json = File.ReadAllText(_path);
            var config = JsonConvert.DeserializeObject<AppConfig>(json);
            return config;
        }
    }
}
