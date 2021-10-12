using System;

namespace WeekSevenAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i < 3)
            {

                Console.WriteLine("sisestage PIN kood");
                string pin = Console.ReadLine();
                Console.WriteLine("sisesta kasutajatunnus:");
                string userName = Console.ReadLine();
                Console.WriteLine("sisesta parool:");
                string password = Console.ReadLine();
                if (pin.Length > 4)
                {
                    Console.WriteLine("Vale PIN proovi uuesti");
                }
                else if (userName == "user1" && password == "password1" && pin == "1532")
                {
                    Console.WriteLine("Tere Tulemast");
                    break;
                }
                else
                {
                    Console.WriteLine("Midagi läks valesti. Proovige uuesti.");
                }
            }
        }
    }
}
