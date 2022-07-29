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
        public static HtmlNodeCollection FuncSait(HtmlWeb web, HtmlNodeCollection NoAltElements)
        {
            string url = "https://world-weather.ru/pogoda/russia";
            HtmlDocument HD = new HtmlDocument();


            BrowserCreationAndEncoding();
            HD = web.Load(url);


            RequestingXPathData(HD);
            HtmlNode HN;

            if (NoAltElements != null)

                for (int i = 0; i < NoAltElements.Count; i++)
                {
                    HN = NoAltElements[i];
                    string outputText = HN.InnerText;
                    Console.WriteLine($"{i}){outputText}\n");
                }
            return NoAltElements;

        }

        public static HtmlNodeCollection RequestingXPathData(HtmlDocument HD)
        {
            HtmlNodeCollection NoAltElements = HD.DocumentNode.SelectNodes("/html[1]/body[1]/div[1]/div[2]/div[1]/div[3]/div/ul/li/a");
            return NoAltElements;
        }

        public static HtmlWeb BrowserCreationAndEncoding()
        {
            var web = new HtmlWeb
            {
                AutoDetectEncoding = false,
                OverrideEncoding = Encoding.UTF8,
            };
            return web;
        }

    }
}