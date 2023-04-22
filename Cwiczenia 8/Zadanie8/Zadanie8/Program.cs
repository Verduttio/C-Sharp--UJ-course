using System;
using System.Text;
using System.Net;
using System.Net.NetworkInformation;
using System.ComponentModel;
using System.Threading;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;


namespace Zadanie8
{
    class Program
    {
        public static string[] LoadCountries()
        {
            string[] lines = System.IO.File.ReadAllLines("ping.txt");
            return lines;
        }

        public static Country GetCountryFromLine(string line)
        {
            string name = line.Substring(0, line.IndexOf(';'));
            string webAddress = line.Substring(line.IndexOf(';')+1);

            var country = new Country();
            country.Name = name;
            country.WebAddress = webAddress;

            return country;
        }

        public static void Main(string[] args)
        {
            var countries = new Queue<Country>();
            string[] lines = LoadCountries();
            for(int i = 1; i < lines.Length; i++)
            {
                countries.Enqueue(GetCountryFromLine(lines[i]));
            }

            PingingWebsite.Countries = countries;

            Stopwatch sw = new Stopwatch();

            // Pierwszy sposób
            Console.WriteLine("----\nSposób 1----\n");
            sw.Start();
            Thread ping1 = PingingWebsite.Run();
            Thread ping2 = PingingWebsite.Run();
            Thread ping3 = PingingWebsite.Run();
            Thread ping4 = PingingWebsite.Run();

            ping1.Join();
            ping2.Join();
            ping3.Join();
            ping4.Join();

            sw.Stop();
            Console.WriteLine("Duration: " + sw.ElapsedMilliseconds + "ms");

            // Drugi sposób
            Console.WriteLine("----\nSposób 2----\n");
            sw.Reset();
            var countriesList = new List<Country>();
            for (int i = 1; i < lines.Length; i++)
            {
                countriesList.Add(GetCountryFromLine(lines[i]));
            }
            sw.Start();
            countriesList.AsParallel().WithDegreeOfParallelism(4).ForAll(p => p.Ping());
            sw.Stop();
            Console.WriteLine("Duration: " + sw.ElapsedMilliseconds + "ms");

            // Trzeci sposób
            Console.WriteLine("----\nSposób 3----\n");
            PingingWebsite.Countries = countries;
            for (int i = 1; i < lines.Length; i++)
            {
                countries.Enqueue(GetCountryFromLine(lines[i]));
            }
            sw.Reset();
            sw.Start();
            Task task1 = PingingWebsite.RunTask();
            Task task2 = PingingWebsite.RunTask();
            Task task3 = PingingWebsite.RunTask();
            Task task4 = PingingWebsite.RunTask();

            task1.Wait();
            task2.Wait();
            task3.Wait();
            task4.Wait();
            sw.Stop();
            Console.WriteLine("Duration: " + sw.ElapsedMilliseconds + "ms");

        }

    }
}
