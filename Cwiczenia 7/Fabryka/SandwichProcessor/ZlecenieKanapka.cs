using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Common;

namespace SandwichProcessor
{
    public class ZlecenieKanapka : Izlecenie
    {
        public string Title { get; set; }
        public void Process()
        {
            Console.WriteLine("\nZlecenieKanapka - Tytuł: " + Title);
            Console.WriteLine("Jajka obierz i drobno pokrój.");
            Thread.Sleep(1000);
            Console.WriteLine("Wymieszaj jajka z Majonezem i chrzanem. Dopraw solą i pieprzem.");
            Thread.Sleep(1000);
            Console.WriteLine("Kromki chleba posmaruj pastą jajeczną.");
            Thread.Sleep(1000);
            Console.WriteLine("Pomidora sparz, obierz ze skórki i pokrój w plastry.");
            Thread.Sleep(1000);
            Console.WriteLine("Na dwóch kromkach chleba połóż plastry szynki, pomidora i salami.");
            Thread.Sleep(1000);
            Console.WriteLine("Dwie kromki ułóż na sobie. Na wierzchu ułóż trzecią kromkę, pastą do dołu.");
            Thread.Sleep(1000);
            Console.WriteLine("Kanapki dociśnij, zetnij brzegi, zepnij wykałaczkami i przekrój po przekątnych, na cztery trójkąty.");
            Thread.Sleep(1000);
            Console.WriteLine("Udekoruj ćwiartkami pomidorków koktajlowych.");
        }
    }
}
