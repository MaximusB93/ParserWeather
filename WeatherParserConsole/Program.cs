using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace WeatherParserConsole
{
    internal class Program
    {
        public static void Main(string[] args)
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


            Console.WriteLine("Выберите регион");
            int IndexRegion = int.Parse(Console.ReadLine());


            HN = NoAltElements[IndexRegion];

            string Region = HN.Attributes["href"].Value;
            HD = new HtmlDocument();

            web = new HtmlWeb
            {
                AutoDetectEncoding = false,
                OverrideEncoding = Encoding.UTF8,
            };
            HD = web.Load(Region);

            NoAltElements = HD.DocumentNode.SelectNodes("/html/body/div[1]/div[2]/div[1]/div[2]/div[2]/div/ul/li/a");

            if (NoAltElements != null)

                for (int i = 0; i < NoAltElements.Count; i++)
                {
                    HN = NoAltElements[i];
                    string outputText = HN.InnerText;
                    Console.WriteLine($"{i}){outputText}\n");
                }

            Console.WriteLine("Выберите город");
            int IndexGorod = int.Parse(Console.ReadLine());


            HN = NoAltElements[IndexGorod];

            string Gorod = "http:" + HN.Attributes["href"].Value;
            HD = new HtmlDocument();

            web = new HtmlWeb
            {
                AutoDetectEncoding = false,
                OverrideEncoding = Encoding.UTF8,
            };
            HD = web.Load(Gorod);

            NoAltElements = HD.DocumentNode.SelectNodes("/html/body/div[1]/div[2]/div[1]/div[2]/div[2]/dl/dt");
            HtmlNodeCollection NoAltElements2 = HD.DocumentNode.SelectNodes("/html/body/div[1]/div[2]/div[1]/div[2]/div[2]/dl/dd");

            if (NoAltElements != null & NoAltElements2 != null)

                for (int i = 0; i < NoAltElements.Count; i++)
                {
                    HN = NoAltElements[i];
                    HtmlNode HN2 = NoAltElements2[i];
                    string outputText = HN.InnerText;
                    string outputText2 = HN2.InnerText;
                    Console.WriteLine($"{outputText}\t {outputText2}\n");

                }
        }
    }
}