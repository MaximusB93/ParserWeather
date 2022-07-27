using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace WeatherParserConsole
{
    internal class Gorod
    {
        public static void FuncGorod(HtmlNodeCollection NoAltElements)
        {
            Console.WriteLine("Выберите город");
            int IndexGorod = int.Parse(Console.ReadLine());


            HtmlNode HN = NoAltElements[IndexGorod];

            string Gorod = "http:" + HN.Attributes["href"].Value;
            HtmlDocument HD = new HtmlDocument();

            var web = new HtmlWeb
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