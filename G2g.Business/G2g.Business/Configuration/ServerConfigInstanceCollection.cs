using System.Configuration;

namespace G2g.Business.Configuration
{
    public class ServerConfigInstanceCollection : ConfigurationElementCollection
    {
        protected override ConfigurationElement CreateNewElement()
        {
            return new ServerConfigInstanceElement();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            //set to whatever Element Property you want to use for a key
            return ((ServerConfigInstanceElement)element).Name;
        }
    }
}
