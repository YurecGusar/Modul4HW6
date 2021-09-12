using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using Modul4HW6.Configs;

namespace Modul4HW6.Services
{
    public class AppConfigService
    {
        private const string _path = @"E:\A-Level\YurecGusar\Modul4HW6\Modul4HW6\Modul4HW6\config.json";
        public AppConfigService()
        {
            var config = GetAppConfig();
            ConnectionString = config.ConnectionString;
        }

        public string ConnectionString { get; set; }

        private AppConfig GetAppConfig()
        {
            var json = File.ReadAllText("config.json");
            var config = JsonConvert.DeserializeObject<AppConfig>(json);
            return config;
        }
    }
}
