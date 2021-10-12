using System;

namespace FirstNameReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mis on su eesnimi");
            string eesnimi = Console.ReadLine();

            if (eesnimi.Length >= 5)
            {
                for (int i = eesnimi.Length - 1; i >= 1; i--)
                {
                    Console.WriteLine(eesnimi[i]);
                }

            }
            else
            {
                Console.WriteLine(eesnimi);
            }
        }
    }
}
