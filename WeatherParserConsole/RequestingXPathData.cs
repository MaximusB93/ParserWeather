using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;


namespace WeatherParserConsole
{
    internal class RequestingXPathData
    {
        /// <summary>
        /// Извлечение контейнера регионов
        /// </summary>
        /// <param name="HD"></param>
        /// <returns></returns>
        public static HtmlNodeCollection RequestingXPathRegions(HtmlDocument HD)
        {
            HtmlNodeCollection NoAltElements = HD.DocumentNode.SelectNodes("/html[1]/body[1]/div[1]/div[2]/div[1]/div[3]/div/ul/li/a");
            return NoAltElements;
        }
        /// <summary>
        /// Извлечение контейнера городов
        /// </summary>
        /// <param name="HD"></param>
        /// <returns></returns>
        public static HtmlNodeCollection RequestingXPathCities(HtmlDocument HD)
        {
            HtmlNodeCollection NoAltElements = HD.DocumentNode.SelectNodes("/html/body/div[1]/div[2]/div[1]/div[2]/div[2]/div/ul/li/a");
            return NoAltElements;
        }
        /// <summary>
        /// Извлечение контейнера погоды
        /// </summary>
        /// <param name="HD"></param>
        /// <returns></returns>
        public static void RequestingXPathWeather(HtmlDocument HD)
        {
            HtmlNodeCollection NoAltElements = HD.DocumentNode.SelectNodes("/html/body/div[1]/div[2]/div[1]/div[2]/div[2]/dl/dt");
            HtmlNodeCollection NoAltElements2 = HD.DocumentNode.SelectNodes("/html/body/div[1]/div[2]/div[1]/div[2]/div[2]/dl/dd");
        }

    }
}