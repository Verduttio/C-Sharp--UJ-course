using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Zadanie4
{
    static class Zadanie2
    {
        public static void Run()
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());

            Random rand = new Random();

            List<List<int>> matrix = Enumerable.Range(1, N).Select(row => Enumerable.Range(1, M).Select(element => rand.Next(10)).ToList()).ToList();

            var query = matrix.SelectMany(row =>
                                            {
                                                row.Select(element =>
                                                  {
                                                      Console.Write(element + " "); 
                                                      return element; 
                                                  }
                                                ).ToList();
                                                Console.WriteLine();
                                                return row;
                                            }).ToList();

            // Testy
            /*foreach(var el in query)
                Console.WriteLine(el);*/

            Console.WriteLine($"\nSum: {query.Sum()}");

            // Testy
            /*foreach(var row in matrix)
            {
                foreach(var element in row)
                {
                    Console.Write(element + " ");
                }
                Console.WriteLine();
            }*/
        }
    }
}
