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

        public static void Main()
        {
            GettingHTMLFromAWebsite.FuncBrowserCreationAndEncoding();
            GettingHTMLFromAWebsite.StartParsing();

        }
    }
}