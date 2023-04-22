using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace WikiMetric
{
    class Crawler
    {
        private Crawler source;
        private string websiteAddress;
        private string websiteTitle;
        private int depth;

        private string wikiLanguage;

        public static int MAX_DEPTH = 2;

        private string destinationAddress;

        private List<string> hrefs;

        private string websiteContent;

        private static List<string> hrefsVisited = new List<string>();
        private static ReaderWriterLock writeToFileLocker = new ReaderWriterLock();
        private static ReaderWriterLock devConsoleOutput = new ReaderWriterLock();
        

        public Crawler (Crawler sourceT, string websiteAddressT, string websiteTitleT, int depthT, string destinationAdrsT, string wikipediaLanguage)
        {
            Thread.CurrentThread.Priority = (ThreadPriority)depth;
            
            source = sourceT;
            websiteAddress = websiteAddressT;
            websiteTitle = websiteTitleT;
            depth = depthT;
            destinationAddress = destinationAdrsT;
            hrefs = new List<string>();
            wikiLanguage = wikipediaLanguage;
            if (source != null)
            {               
                lock (devConsoleOutput)
                {
                    using (StreamWriter file = new("consoleOutput.txt", append: true))
                    {
                        file.WriteLineAsync("CURRENT SITE: " + websiteTitle + " | SOURCE: " + source.websiteTitle + " | DEPTH: " + depth + "\n");
                    }
                }
                Console.WriteLine("CURRENT SITE: " + websiteTitle + " | SOURCE: " + source.websiteTitle + " | DEPTH: " + depth);
            }
            else 
            {                
                lock (devConsoleOutput)
                {
                    // All text from console is written to consoleOutput.txt file
                    using (StreamWriter file = new("consoleOutput.txt", append: true))
                    {
                        file.WriteLineAsync("CURRENT SITE: " + websiteTitle + " | SOURCE: " + " | DEPTH: " + depth + "\n");
                    }
                }
                Console.WriteLine("CURRENT SITE: " + websiteTitle + " | SOURCE: " + " | DEPTH: " + depth);
            }

            
            if (websiteTitle == destinationAddress)
            {
                lock (devConsoleOutput) {
                    // All text from console is written to consoleOutput.txt file
                    using (StreamWriter file = new("consoleOutput.txt", append: true))
                    {
                        file.WriteLineAsync("***FOUND!!!!***");
                    }
                }

                Console.WriteLine("***FOUND!!!***");

                lock (writeToFileLocker)
                {
                    WritePathToFile();
                }
                Program.found = true;

            }
            else
            {
                ReadWebsiteContent();
                FindHrefs();
                StartSearching();
            }
        }

      

        private void WritePathToFile()
        {
            lock (writeToFileLocker) {
                using (StreamWriter file = new("Path.txt", append: true))
                {
                    file.WriteLineAsync(PathToSource());
                }
            }
        }

        public string PathToSource()
        {
            string path = websiteTitle + " <- ";
            Crawler previous = source;
            while(previous != null)
            {
                if (previous.source == null)
                    path += previous.websiteAddress;
                else 
                    path += previous.websiteTitle + " <- ";
                previous = previous.source;
            }
            path += "\n\n";

            return path;
        }

        public void StartSearching() 
        {
            if (depth < MAX_DEPTH && !Program.found)
            {
                foreach (var subWebsite in hrefs)
                {
                    Task bornedCrawler = Task.Run(() => new Crawler(this, "https://"+ wikiLanguage+".wikipedia.org/" + subWebsite, subWebsite, depth + 1, destinationAddress, wikiLanguage));
                }
            }
        }


        public void FindHrefs()
        {
            var regex = new Regex("<a href=\"/wiki/([^:\"]*)\"", RegexOptions.IgnoreCase); // działa
            var urls = regex.Matches(websiteContent).OfType<Match>().Select(m => m).ToList();
            foreach (var href in urls)
            {

                string wikiSubWebsite = href.ToString().Substring(9, href.ToString().Length - 9 - 1);
                    if (!hrefsVisited.Contains(wikiSubWebsite))
                    {
                        hrefs.Add(wikiSubWebsite);
                        hrefsVisited.Add(wikiSubWebsite);
                    }
            }
        }

        private void ReadWebsiteContent()
        {
            WebClient web = new WebClient();
            System.IO.Stream stream = web.OpenRead(websiteAddress);
            String websiteCntn;
            using (System.IO.StreamReader reader = new System.IO.StreamReader(stream))
            {
                websiteCntn = reader.ReadToEnd();
            }

            websiteContent = websiteCntn;
        }


    }
}
