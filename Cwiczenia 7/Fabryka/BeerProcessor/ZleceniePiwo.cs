using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Common;

namespace BeerProcessor
{
    public class ZleceniePiwo : Izlecenie
    {
        public string Title { get; set; }
        public void Process ()
        {
            Console.WriteLine("\nZleceniePiwo - Tytuł: " + Title);
            Console.WriteLine("Dodaj słody.");
            Thread.Sleep(2000);
            Console.WriteLine("Zacieranie w około 66 stopniach Celsjusza.");
            Thread.Sleep(2000);
            Console.WriteLine("Dodaj słody.");
            Thread.Sleep(2000);
            Console.WriteLine("Chmielenie.");
            Thread.Sleep(2000);
            Console.WriteLine("Dodanie drożdży.");
            Thread.Sleep(2000);
            Console.WriteLine("Fermentacja.");
            Thread.Sleep(2000);
            Console.WriteLine("Chmielenie na zimno.");
            Thread.Sleep(2000);
        }
    }
}
