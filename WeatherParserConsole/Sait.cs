using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace WeatherParserConsole
{
    internal class Sait
    {
        public static HtmlNodeCollection FuncSait()
        {
            string html = "https://world-weather.ru/pogoda/russia";
            HtmlDocument HD = new HtmlDocument();

            var web = new HtmlWeb
            {
                AutoDetectEncoding = false,
                OverrideEncoding = Encoding.UTF8,
            };

            HD = web.Load(html);

            HtmlNodeCollection NoAltElements = HD.DocumentNode.SelectNodes("/html[1]/body[1]/div[1]/div[2]/div[1]/div[3]/div/ul/li/a");
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
    }
}