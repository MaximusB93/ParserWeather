using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace WeatherParserConsole
{
    internal class Region
    {
        public static void FuncRegion(HtmlNodeCollection NoAltElements)
        {
            Console.WriteLine("Выберите регион");
            int IndexRegion = int.Parse(Console.ReadLine());


            HtmlNode HN = NoAltElements[IndexRegion];

            string Region = HN.Attributes["href"].Value;
            HtmlDocument HD = new HtmlDocument();

            var web = new HtmlWeb
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


        }
    }
}