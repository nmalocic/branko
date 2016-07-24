using G2g.Business;
using G2g.Business.Configuration;
using G2g.Business.Util;
using System;
using System.Configuration;

namespace g2g.Test
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            //var config = ConfigurationManager.GetSection("domainEu") as ServersConfigSection;

            //WowManager wowMng = new WowManager();
            //wowMng.ProcessServers(config.Servers);

            ConfigGenerator configGenerator = new ConfigGenerator();

            configGenerator.GenerateConfigFromCsv(@"D:\Programiranje\G2gCrawler\euServers.txt", @"D:\Programiranje\G2gCrawler\app.txt", "gold-2522-19248");
        }
    }
}
