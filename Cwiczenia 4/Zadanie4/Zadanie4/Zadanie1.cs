using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie4
{
    static class Zadanie1
    {
        public static void Run()
        {
            int N = int.Parse(Console.ReadLine());
            var list = Enumerable.Range(1, N).ToList();
            var query = from number in list
                        where number != 5 && number != 9 && (number % 2 == 1 || number % 7 == 0)
                        select number*number;

            foreach(var number in query)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine($"Suma wszystkich elementów: {query.Sum()}");
            Console.WriteLine($"Liczba wszystkich elementów: {query.Count()}");
            Console.WriteLine($"Pierwszy element: {query.First()}");
            Console.WriteLine($"Ostatni element: {query.Last()}");
            Console.WriteLine($"Trzeci element: {query.ElementAt(2)}");
           


        }
    }
}
