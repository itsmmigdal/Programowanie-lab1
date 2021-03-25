using System;

namespace KC008
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            for (int i = 1; i < t; i++)
            {
                int suma = 0;
                int n = int.Parse(Console.ReadLine());
                string linia = Console.ReadLine();
                var tab = linia.Split(' ');
                for (int j = 0; j < tab.Length; j++)
                {
                    int liczba = int.Parse(tab[j]);
                    suma += liczba;
                }
                Console.WriteLine(suma);
            }
        }
    }
}