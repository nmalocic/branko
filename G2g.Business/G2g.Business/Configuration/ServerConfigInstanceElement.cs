using System.Configuration;

namespace G2g.Business.Configuration
{
    public class ServerConfigInstanceElement : ConfigurationElement
    {
        //Make sure to set IsKey=true for property exposed as the GetElementKey above
        [ConfigurationProperty("realmId", IsKey = true, IsRequired = true)]
        public string RealmId
        {
            get { return (string)base["realmId"]; }
            set { base["realmId"] = value; }
        }

        [ConfigurationProperty("serverId", IsRequired = true)]
        public string ServerId
        {
            get { return (string)base["serverId"]; }
            set { base["serverId"] = value; }
        }

        [ConfigurationProperty("name", IsKey = true, IsRequired = true)]
        public string Name
        {
            get { return (string)base["name"]; }
            set { base["name"] = value; }
        }

        public float Price { get; set; }
    }
}
