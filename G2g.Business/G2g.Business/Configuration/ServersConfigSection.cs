using System.Configuration;

namespace G2g.Business.Configuration
{
    public class ServersConfigSection : ConfigurationSection
    {
        [ConfigurationProperty("", IsRequired = true, IsDefaultCollection = true)]
        public ServerConfigInstanceCollection Servers
        {
            get { return (ServerConfigInstanceCollection)this[""]; }
            set { this[""] = value; }
        }
    }
}
