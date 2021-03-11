using System;

namespace ConsoleAppInteraktywna
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Witaj!");

            Console.Write("Podaj imię: ");
            string imie;
            imie = Console.ReadLine();

            Console.WriteLine("Podaj nazwisko");
            string nazwisko = Console.ReadLine();
            
            
            Console.WriteLine("Witaj " + imie + " " + nazwisko + "!");

            var napis = string.Format("Witaj {0} {1}!", imie, nazwisko,);
            Console.WriteLine(napis);

            Console.WriteLine("Witaj {0} {1}!", imie, nazwisko);
            Console.WriteLine($"Witaj {imie} {nazwisko}!");


            Console.WriteLine("Podaj wiek: ");
            string wiekJakoNapis = Console.ReadLine();
            int wiek = int.Parse(wiekJakoNapis);

            if (wiek < 65)
            {
                Console.WriteLine( $"Do emerytury zostało Ci {65-wiek} lat");
            }
            else
            {
                Console.WriteLine("Jesteś emerytem")
            }
        }
    }
}
