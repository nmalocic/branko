using System.IO;
using System.Text;

namespace G2g.Business.Util
{
    public class ConfigGenerator
    {
        public readonly string _format = @"<add realmId=""{0}"" serverId=""{1}"" name=""{2}"" />";

        public void GenerateConfigFromCsv(string csvFilePath, string configFilePath, string realmId)
        {
            StringBuilder builder = new StringBuilder();

            using (var reader = new StreamReader(File.OpenRead(csvFilePath)))
            {
                while(!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    var serverId = values[0];
                    var name = values[1];

                    builder.AppendLine(string.Format(_format, realmId, serverId, name));
                }
            }

            File.WriteAllText(configFilePath, builder.ToString());
        }
    }
}
