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
        static void Main(string[] args)
        {

            ////HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            ////doc.Load(@"https://world-weather.ru/pogoda/russia");

            //////HtmlNodeCollection collection = doc.GetElementbyId(“id”);


            //var html = @"https://world-weather.ru/pogoda/russia/";

            //HtmlWeb web = new HtmlWeb();

            //var htmlDoc = web.Load(html);

            //var node = htmlDoc.DocumentNode.SelectSingleNode("//body//div//ul//li/a");

            //Console.WriteLine("Node Name: " + node.Name + "\n" + node.OuterHtml);


            string html = "https://world-weather.ru/pogoda/russia";
            HtmlDocument HD = new HtmlDocument();

            var web = new HtmlWeb
            {
                AutoDetectEncoding = false,
                OverrideEncoding = Encoding.UTF8,
            };
            HD = web.Load(html);

            HtmlNodeCollection NoAltElements = HD.DocumentNode.SelectNodes("/html[1]/body[1]/div[1]/div[2]/div[1]/div[3]/div[1]/ul/li/a");

            if (NoAltElements != null)

                for (int i = 0; i < NoAltElements.Count; i++)
                {
                    HtmlNode HN = NoAltElements[i];
                    string outputText = HN.InnerText;
                    Console.WriteLine($"{i}){outputText}\n");
                }

            Console.WriteLine("Выберите регион");
            int IndexRegion = int.Parse(Console.ReadLine());

            FuncGoroda();

        }

        public static void FuncGoroda()
        {
            HtmlNodeCollection NoAltElements = null;
            HN = NoAltElements[IndexRegion];

            string Gorod = HN.Attributes["href"].Value;
            HtmlDocument HD = new HtmlDocument();

            var web = new HtmlWeb
            {
                AutoDetectEncoding = false,
                OverrideEncoding = Encoding.UTF8,
            };
            HD = web.Load(Gorod);

            NoAltElements = HD.DocumentNode.SelectNodes("/html[1]/body[1]/div[1]/div[2]/div[1]/div[3]/div[1]/ul/li/a");

            if (NoAltElements != null)

                for (int i = 0; i < NoAltElements.Count; i++)
                {
                    HN = NoAltElements[i];
                    string outputText = HN.InnerText;
                    Console.WriteLine($"{i}){outputText}\n");
                }
        }
        //string outputText = HN.Attributes["href"].Value;
        //string html2 = NoAltElements[0].OuterHtml








    }





    //private static object Parsing(string url)
    //{
    //    try
    //    {
    //        using (HttpClientHandler hd1 = new HttpClientHandler { })
    //        {
    //            using (var clien = new HttpClient(hd1))
    //            {

    //            }

    //        }
    //    }
    //    catch (Exception ex) { Console.WriteLine(ex.Message); }
    //    {

    //        return null;
    //    }
    //}
}
