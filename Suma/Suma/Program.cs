using System;

namespace SPOJ1_xzv
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            for (int i = 1; i < t; i++)
            {
                int n = int.Parse(Console.ReadLine());
                string linia = Console.ReadLine();
                var tab = linia.Split(' ');
                for (int j = 0; j < n; j++)
                {
                    int liczba = int.Parse(tab[j]);
                    suma += liczba;
                }
                Console.WriteLine(suma);
            }
        }
    }
}
