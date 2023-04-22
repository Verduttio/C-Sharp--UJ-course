using System;
using System.IO;
using System.Reflection;

namespace Fabryka
{
    class Program
    {
        static void Main(string[] args)
        {

            foreach(var arg in args)
            {
                string filePath = arg.Substring(0, arg.IndexOf(';'));
                string title = arg.Substring(arg.IndexOf(';')+1);

                FileInfo f = new FileInfo(filePath);

                // Wczytujemy assembly
                Assembly assembly = Assembly.LoadFrom(f.FullName);

                // Pobieramy typ klasy, który chcemy wyciągnąć z assembly
                Type t;
                if (filePath.Contains("BeerProcessor.dll"))
                    t = assembly.GetType("BeerProcessor.ZleceniePiwo");
                else
                    t = assembly.GetType("SandwichProcessor.ZlecenieKanapka");

                // Pobieramy adres delegaty do metody Processs
                // To samo robimy z propercją
                MethodInfo process = t.GetMethod("Process");
                PropertyInfo piTitle = t.GetProperty("Title");

                object o = Activator.CreateInstance(t);

                // Ustawiamy wartość propercji
                piTitle.SetValue(o, title);

                // Wywołujemy metodę Process
                process.Invoke(o, null);
            }
        }
    }
}
