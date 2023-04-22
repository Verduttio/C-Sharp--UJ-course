using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace WikiMetric
{
    class Program
    {
        public static bool found = false;
        static void Main(string[] args)
        {
            // Wyniki dzialania programu (czyli ścieżka od źródła do celu) 
            // zapisywane są w /bin/Debug/net5.0/ w plikach Path.txt oraz consoleOutput.txt.

            // W Path znajduje się ścieżka, zaś w consoleOutput.txt znajduje się to
            // co wypisane jest na konsoli.

            DeleteFilesIfExist();

            // Przykladowe dzialanie, poniewaz dla metryki Hitlera
            // program nie moze go znalezc ;( chyba nie za bardzo go lubi...
            Crawler.MAX_DEPTH = 2;
            const string wikiLanguage = "pl";
            Task testCrawler = Task.Run(() => { new Crawler(null, "http://" + wikiLanguage + ".wikipedia.org/wiki/Stanis%C5%82aw_Mig%C3%B3rski", null, 0, "/wiki/Profesor_(stanowisko)", wikiLanguage); });

            // Metryka Hitlera
            //Crawler.MAX_DEPTH = 10;
            //const string wikiLanguage = "en";
            //Task hitlerCrawler = Task.Run(() => { new Crawler(null, "http://" + wikiLanguage + ".wikipedia.org/wiki/Special:Random", null, 0, "/wiki/Adolf_Hitler", wikiLanguage); });

            while (!found) { }
        }

        public static void DeleteFilesIfExist()
        {
            if (File.Exists("consoleOutput.txt"))
            {
                File.Delete("consoleOutput.txt");
            }

            if (File.Exists("Path.txt"))
            {
                File.Delete("Path.txt");
            }
        }
    }
}
