using System;

namespace RandomLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta oma eesnimi");
            string eesnimi = Console.ReadLine();
            Random rnd = new Random();

            int taht = rnd.Next(0, eesnimi.Length - 1);
            Console.WriteLine(eesnimi[taht]);
        }
    }
}
