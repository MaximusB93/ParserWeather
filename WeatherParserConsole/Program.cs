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
            GettingHTMLFromAWebsite.GettingRegionsFromAWebsite();


            //RequestingXPathData.RequestingXPathRegions(GettingHTMLFromAWebsite.GettingRegionsFromAWebsite());


            DataOutputConsole.DataRegionsAnd—itiesConsole(RequestingXPathData.RequestingXPathRegions(GettingHTMLFromAWebsite.GettingRegionsFromAWebsite()));



            /*HtmlNodeCollection NoAltElements2 = */
            GettingHTMLFromAWebsite.GettingCitiesFromAWebsite(DataOutputConsole.DataRegionsAnd—itiesConsole());
            DataOutputConsole.DataRegionsAnd—itiesConsole(RequestingXPathData.RequestingXPathCities(GettingHTMLFromAWebsite.GettingCitiesFromAWebsite()));
            //GettingHTMLFromAWebsite.GettingWeatherFromAWebsite(NoAltElements2);
        }
    }
}