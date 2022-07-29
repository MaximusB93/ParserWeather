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
        /// <summary>
        /// ��������� �������� � �����
        /// </summary>
        public static HtmlDocument GettingRegionsFromAWebsite()
        {
            string UrlNation = "https://world-weather.ru/pogoda/russia";
            HtmlWeb web = BrowserCreationAndEncoding.FuncBrowserCreationAndEncoding();
            HtmlDocument HD = web.Load(UrlNation);
            return HD;
        }
        /// <summary>
        /// ��������� ������� � �����
        /// </summary>
        public static void GettingCitiesFromAWebsite(HtmlNodeCollection NoAltElements)
        {
            Console.WriteLine("�������� ������");
            int IndexRegion = int.Parse(Console.ReadLine());
            HtmlNode HN = NoAltElements[IndexRegion];
            string UrlRegions = HN.Attributes["href"].Value;
            HtmlWeb web = BrowserCreationAndEncoding.FuncBrowserCreationAndEncoding();
            HtmlDocument HD = web.Load(UrlRegions);
        }
        /// <summary>
        /// ��������� ������ � �����
        /// </summary>
        public static void GettingWeatherFromAWebsite(HtmlNodeCollection NoAltElements)
        {
            Console.WriteLine("�������� �����");
            int IndexCity = int.Parse(Console.ReadLine());
            HtmlNode HN = NoAltElements[IndexCity];
            string UrlCities = "http:" + HN.Attributes["href"].Value;
            HtmlWeb web = BrowserCreationAndEncoding.FuncBrowserCreationAndEncoding();
            HtmlDocument HD = web.Load(UrlCities);
        }
    }
}
