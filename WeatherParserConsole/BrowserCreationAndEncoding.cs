using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace WeatherParserConsole
{
    internal class BrowserCreationAndEncoding
    {
        /// <summary>
        /// Создание браузера и условий кодировки
        /// </summary>
        /// <returns></returns>
        public static HtmlWeb FuncBrowserCreationAndEncoding()
        {
            var web = new HtmlWeb
            {
                AutoDetectEncoding = false,
                OverrideEncoding = Encoding.UTF8,
            };
            return web;
        }
    }
}