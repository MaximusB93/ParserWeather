using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace WeatherParserConsole
{
    internal class GettingHTMLFromAWebsite
    {
        private static HtmlWeb web;
        private static HtmlNodeCollection regions;
        private static HtmlNodeCollection cities;
        /// <summary>
        /// Получение городов с сайта
        /// </summary>
        //public static void GettingCitiesFromAWebsite()
        //{
        //    Console.WriteLine("Выберите регион");
        //    int IndexRegion = int.Parse(Console.ReadLine());
        //    HtmlNode HN = regions[IndexRegion];
        //    string UrlRegions = HN.Attributes["href"].Value;
        //    HtmlDocument HD = web.Load(UrlRegions);
        //    cities = HD.DocumentNode.SelectNodes("/html/body/div[1]/div[2]/div[1]/div[2]/div[2]/div/ul/li/a");
        //}
        ///// <summary>
        ///// Получение погоды с сайта
        ///// </summary>
        //public static void GettingWeatherFromAWebsite()
        //{
        //    Console.WriteLine("Выберите город");
        //    int IndexCity = int.Parse(Console.ReadLine());
        //    HtmlNode HN = cities[IndexCity];
        //    string UrlCities = "http:" + HN.Attributes["href"].Value;
        //    HtmlDocument HD = web.Load(UrlCities);
        //    HtmlNodeCollection DescrType = HD.DocumentNode.SelectNodes("/html/body/div[1]/div[2]/div[1]/div[2]/div[2]/dl/dt");
        //    HtmlNodeCollection DescrValue = HD.DocumentNode.SelectNodes("/html/body/div[1]/div[2]/div[1]/div[2]/div[2]/dl/dd");
        //}
        /// <summary>
        /// Создание браузера и условий кодировки
        /// </summary>
        /// <returns></returns>
        public static void FuncBrowserCreationAndEncoding()
        {
            var web = new HtmlWeb
            {
                AutoDetectEncoding = false,
                OverrideEncoding = Encoding.UTF8,
            };
        }
        private static void ParsingFromWebsite(HtmlNodeCollection htmlNodes, string Url, string XPath, int Index)
        {
            HtmlNode HN = htmlNodes[Index];
            HtmlDocument HD = web.Load(Url);
            htmlNodes = HD.DocumentNode.SelectNodes(XPath);
            //return htmlNodes;
            DataOutputConsole.DataRegionsAndСitiesConsole(htmlNodes);
        }
        public static void StartParsing()
        {
            string UrlNation = "https://world-weather.ru/pogoda/russia";
            HtmlWeb web = new HtmlWeb();
            HtmlDocument HD = web.Load(UrlNation);
            regions = HD.DocumentNode.SelectNodes("/html[1]/body[1]/div[1]/div[2]/div[1]/div[3]/div/ul/li/a");
            DataOutputConsole.DataRegionsAndСitiesConsole(regions);
            Console.WriteLine("Выберите регион");
            int IndexRegion = int.Parse(Console.ReadLine());
            HtmlNode HN = regions[IndexRegion];
            ParsingFromWebsite(regions, HN.Attributes["href"].Value, "/html/body/div[1]/div[2]/div[1]/div[2]/div[2]/div/ul/li/a", IndexRegion);
            //HtmlNodeCollection htmlNodes = DataOutputConsole.DataRegionsAndСitiesConsole();

            //Console.WriteLine("Выберите город");
            //int IndexCity = int.Parse(Console.ReadLine());
            //HN = cities[IndexCity];
            //string UrlCities = "http:" + HN.Attributes["href"].Value;
            //HD = web.Load(UrlCities);
            //HtmlNodeCollection DescrType = HD.DocumentNode.SelectNodes("/html/body/div[1]/div[2]/div[1]/div[2]/div[2]/dl/dt");
            //HtmlNodeCollection DescrValue = HD.DocumentNode.SelectNodes("/html/body/div[1]/div[2]/div[1]/div[2]/div[2]/dl/dd");
        }
    }
}
