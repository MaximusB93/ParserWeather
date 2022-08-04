using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace ParserWeather
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

        public static void DataWeatherConsole(HtmlNodeCollection DescrType, HtmlNodeCollection DescrValue)
        {
            if (DescrType != null & DescrValue != null)

                for (int i = 0; i < DescrType.Count; i++)
                {
                    HtmlNode HN = DescrType[i];
                    HtmlNode HN2 = DescrValue[i];
                    string outputText = HN.InnerText;
                    string outputText2 = HN2.InnerText;
                    Console.WriteLine($"{outputText}\t {outputText2}\n");
                }
        }
    }
}