using G2g.Business.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G2g.Business
{
    public class WowManager
    {
        public void ProcessServers(ServerConfigInstanceCollection servers, string execlFilePath, float priceMargine)
        {
            Crawler crawler = new Crawler(priceMargine);
            ExcelWriter writer = new ExcelWriter(execlFilePath);

            foreach (ServerConfigInstanceElement server in servers)
            {
                crawler.Process(server);
            }

            writer.EditExcel(servers);
        }
    }
}
