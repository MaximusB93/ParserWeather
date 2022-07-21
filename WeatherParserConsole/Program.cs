using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace WeatherParserConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {

            HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc.Load(@"https://world-weather.ru/pogoda/russia"); 

                //HtmlNodeCollection collection = doc.GetElementbyId(“id”);

        }
    }
}
