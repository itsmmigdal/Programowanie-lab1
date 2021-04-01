using System;

namespace Pętla
{
    class Program
    {
        static void Main(string[] args)
        {
            //wczytywanie i parsowanie danych wejściowych
            string wejście = Console.ReadLine();
            int[] dane = Array.ConvertAll<string, int>(wejście.Split(""), int.Parse);
            //Twój Kod
            int a = dane[0];
            int b = dane[1];
            if (a < b)
            {
                if ((b - a) <= 11)
                {
                    if ((b - a) == 1) || (b - a) == -1)
                    {
                        Console.WriteLine("empty");
                    }
                    else
                    {
                        for (int i = ++a; i < (b - 1); i++)
                        {
                            Console.Write($"{i}, ");
                        }
                        Console.Write(b -1);
                    }
                } else if ((b - a) >= 11)
                {
                    for (int i = ++a; i <= (a + 2); i++)
                    {
                        Console.WriteLine($"{i}, ");
                    }
                    Console.Write("..., ");
                    for (int i = (b - 2); i < (b - 1); i++)
                    {
                        Console.Write($"{i}, ");
                    }
                    Console.Write(b - 1);
                }
            } else if (a > b)
            {
                if ((a - b) <= 11)
                {
                    if ((a - b) == 1) || (a - b) == -1)
                    {
                        Console.WriteLine("empty");
                    }
                }
            }
        }
    }
}
