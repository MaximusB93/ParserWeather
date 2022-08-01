using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace WeatherParserConsole
{
    internal class DataOutputConsole
    {
        public static HtmlNodeCollection DataRegionsAnd—itiesConsole(HtmlNodeCollection htmlNodes)
        {
            if (htmlNodes != null)

                for (int i = 0; i < htmlNodes.Count; i++)
                {
                    HtmlNode HN = htmlNodes[i];
                    string outputText = HN.InnerText;
                    Console.WriteLine($"{i}){outputText}\n");
                }
            return htmlNodes;
        }

        public static void DataWeatherConsole(HtmlDocument HD, HtmlNodeCollection NoAltElements, HtmlNodeCollection NoAltElements2)
        {
            if (NoAltElements != null & NoAltElements2 != null)

                for (int i = 0; i < NoAltElements.Count; i++)
                {
                    HtmlNode HN = NoAltElements[i];
                    HtmlNode HN2 = NoAltElements2[i];
                    string outputText = HN.InnerText;
                    string outputText2 = HN2.InnerText;
                    Console.WriteLine($"{outputText}\t {outputText2}\n");
                }
        }
    }
}