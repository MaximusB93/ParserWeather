using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace ParserWeather
{
    internal class GettingHTMLFromAWebsite
    {
        private static HtmlWeb web;
        private static HtmlNodeCollection regions;
        private static HtmlNodeCollection cities;
        public static HtmlWeb FuncBrowserCreationAndEncoding()
        {
            var web = new HtmlWeb
            {
                AutoDetectEncoding = false,
                OverrideEncoding = Encoding.UTF8,
            };
            return web;
        }
        public static void StartParsing()
        {
            string UrlNation = "https://world-weather.ru/pogoda/russia";
            web = FuncBrowserCreationAndEncoding();
            HtmlDocument HD = web.Load(UrlNation);
            regions = HD.DocumentNode.SelectNodes("/html[1]/body[1]/div[1]/div[2]/div[1]/div[3]/div/ul/li/a");
            DataOutputConsole.DataRegionsAndÑitiesConsole(regions);
            Console.WriteLine("Âûáåðèòå ðåãèîí");
            int IndexRegion = int.Parse(Console.ReadLine());
            HtmlNode HN = regions[IndexRegion];
            cities = ParsingFromWebsite(regions, HN.Attributes["href"].Value, "/html/body/div[1]/div[2]/div[1]/div[2]/div[2]/div/ul/li/a", IndexRegion);
            Console.WriteLine("Âûáåðèòå ãîðîä");
            int IndexCity = int.Parse(Console.ReadLine());
            HN = cities[IndexCity];
            string UrlCities = "http:" + HN.Attributes["href"].Value;
            HD = web.Load(UrlCities);
            HtmlNodeCollection DescrType = HD.DocumentNode.SelectNodes("/html/body/div[1]/div[2]/div[1]/div[2]/div[2]/dl/dt");
            HtmlNodeCollection DescrValue = HD.DocumentNode.SelectNodes("/html/body/div[1]/div[2]/div[1]/div[2]/div[2]/dl/dd");
            DataOutputConsole.DataWeatherConsole(DescrType, DescrValue);
        }
        private static HtmlNodeCollection ParsingFromWebsite(HtmlNodeCollection htmlNodes, string Url, string XPath, int Index)
        {
            HtmlNode HN = htmlNodes[Index];
            web = FuncBrowserCreationAndEncoding();
            HtmlDocument HD = web.Load(Url);
            htmlNodes = HD.DocumentNode.SelectNodes(XPath);
            DataOutputConsole.DataRegionsAndÑitiesConsole(htmlNodes);
            return htmlNodes;
        }
    }
}
