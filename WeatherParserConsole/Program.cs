using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using HtmlDocument = HtmlAgilityPack.HtmlDocument;

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

            // Собственно, здесь и производится выборка интересующих нам нодов
            // В данном случае выбираем блочные элементы с классом eTitle
            HtmlNodeCollection NoAltElements = HD.DocumentNode.SelectNodes("/html[1]/body[1]/div[1]/div[2]/div[1]/div[3]/div[1]/ul/li/a");

            // Проверяем наличие узлов
            if (NoAltElements != null)
            {
                foreach (HtmlNode HN in NoAltElements)
                {
                    // Получаем строчки
                    string outputText = HN.InnerText;
                    Console.WriteLine($"{outputText}\n");
                }
            
            }

         

        }
    }
}
