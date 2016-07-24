using ClosedXML.Excel;
using G2g.Business.Configuration;
using System.Linq;

namespace G2g.Business
{
    internal class ExcelWriter
    {
        private string _path;
        private readonly string _nameCell = "B";
        private readonly string _priceCell = "E";

        public ExcelWriter(string path)
        {
            _path = path;
        }

        internal void EditExcel(ServerConfigInstanceCollection servers)
        {
            var workbook = new XLWorkbook(_path);
            var worksheet = workbook.Worksheets.Worksheet(1);

            int index = 10;
            string serverName = null;
            do
            {
                string nameFormula = _nameCell + index;
                serverName = worksheet.Cell(nameFormula).GetValue<string>();

                foreach(ServerConfigInstanceElement item in servers)
                {
                    if (item.Name.ToLower().Equals(serverName.ToLower()))
                    {
                        string priceFolmula = _priceCell + index;
                        worksheet.Cell(priceFolmula).SetValue(item.Price);                        
                        break;
                    }
                }

                index++;
            } while (NameExists(serverName));




            workbook.Save();
        }

        private static bool NameExists(string serverName)
        {
            return !string.IsNullOrEmpty(serverName);
        }
    }
}
