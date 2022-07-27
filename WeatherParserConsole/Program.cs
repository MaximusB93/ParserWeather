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
            
            Sait.FuncSait();
            HtmlNodeCollection NoAltElements = Sait.FuncSait();
            //Region.FuncRegion(NoAltElements);
            HtmlNodeCollection NoAltElements2 = Region.FuncRegion(NoAltElements);
            Gorod.FuncGorod(NoAltElements2);

        }
    }
}