using System;

namespace FullNameInitials
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Palun sisestage oma eesnimi");
            string eesnimi = Console.ReadLine().ToUpper();
            Console.WriteLine("Palun sisestage oma perekonna nimi");
            string perekonnanimi = Console.ReadLine().ToUpper();

            Console.WriteLine($"Tere, {eesnimi[0]}. {perekonnanimi[0]}.");
        }
    }
}
