using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ZadanieDomowe
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Podaj liczbę parlamentarzystów: ");
            int parliamentariansNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj temat głosowania: ");
            String topic = Console.ReadLine();
            var parliament = new Parliament();
            parliament.Topic = topic;

            for(int i = 0; i < parliamentariansNumber; i++)
            {
                Parliamentarian parliamentarian = new Parliamentarian();
                parliamentarian.Id = i + 1;
                parliament.StartedVoting += parliamentarian.OnStartedVoting;
                parliament.FinishedVoting += parliamentarian.OnFinishedVoting;
                parliamentarian.CastedVote += parliament.OnCastedVote;
                parliament.Parliamentarians().Add(parliamentarian);
            }

            parliament.StartVoting();


            Console.ReadKey();
        }
    }
}