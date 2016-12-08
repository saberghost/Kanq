using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kanq.Common
{
    public class ConfigHelper
    {
        public static string Get(string name)
        {
            return ConfigurationManager.AppSettings.Get(name);
        }
        public static void Set(string name, string value)
        {
            ConfigurationManager.AppSettings.Set(name, value);
        }
    }
}
