using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie4
{
    static class Zadanie3
    {
        public static void Run()
        {
            var cities = new List<String>();
            String input = Console.ReadLine();
            while(input != "X")
            {
                cities.Add(input);
                input = Console.ReadLine();
            }

            var groups = from city in cities
                         orderby city
                         group city by city.ElementAt(0) into cityGroup
                         orderby cityGroup.Key
                         select cityGroup;


            while (true)
            {
                char letter = char.Parse(Console.ReadLine());

                var citiesOnLetter = groups.Where(x => x.Key == letter);

                if (citiesOnLetter.Count() != 0)
                {
                    foreach (var group in citiesOnLetter)
                    {
                        foreach (var city in group)
                            Console.Write(city + " ");
                    }
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("PUSTE");
                }

            }
        }

    }
}
