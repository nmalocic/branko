using G2g.Business.Configuration;
using HtmlAgilityPack;
using System.Text.RegularExpressions;

namespace G2g.Business
{
    internal class Crawler
    {
        private readonly float _stockRequired = 500000;
        private readonly string _url = @"https://www.g2g.com/wow-eu/{0}?&server={1}&sorting=price@asc";
        private float _priceMargine;

        public Crawler(float priceMargine)
        {
            _priceMargine = priceMargine;
        }

        internal void Process(ServerConfigInstanceElement server)
        {
            float startingStock = 0;

            string serverUrl = string.Format(_url, server.RealmId, server.ServerId);

            System.Windows.Forms.WebBrowser wb = new System.Windows.Forms.WebBrowser();
            wb.ScriptErrorsSuppressed = true;
            wb.Navigate(serverUrl);
            while (wb.ReadyState != System.Windows.Forms.WebBrowserReadyState.Complete)
            {
                System.Windows.Forms.Application.DoEvents();
            }
            var response = wb.DocumentText;

            HtmlDocument htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(response);

            var table = htmlDoc.DocumentNode.SelectSingleNode("//table[@id='g2g-listing-table']");
            var items = htmlDoc.DocumentNode.SelectNodes("//table[@id='g2g-listing-table']/tbody/tr");

            foreach(var item in items)
            {
                HtmlDocument tempDoc = new HtmlDocument();
                tempDoc.LoadHtml(item.InnerHtml);

                var delivery = tempDoc.DocumentNode.SelectSingleNode("//td[@class='title-delivery']/span").InnerText;
                var stock = tempDoc.DocumentNode.SelectSingleNode("//div[@class='quantity-group']/div[@class='max-qty input-append input-prepend']/label").InnerText.Trim();
                var stockPrice = tempDoc.DocumentNode.SelectSingleNode("//div[@id='ppu-text']/span").InnerText;

                int deliveryTime = ConvertStringToInt(delivery);

                if(deliveryTime <= 1)
                {
                    startingStock += float.Parse(stock);

                    if(startingStock > _stockRequired)
                    {
                        server.Price = float.Parse(stockPrice) + _priceMargine;
                        return;
                    }
                }
            }
        }

        private static int ConvertStringToInt(string delivery)
        {
            return int.Parse(ExtractDigitsFromString(delivery));
        }

        private static string ExtractDigitsFromString(string delivery)
        {
            return Regex.Match(delivery, @"\d+").Value;
        }
    }
}
