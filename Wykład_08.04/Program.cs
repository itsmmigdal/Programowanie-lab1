using System;

namespace Wykład_08._04
{
    class Program
    {
        
        
        public static void Main()
        {
            int[] tab; //tab == null
            tab = new int[10];
            Random los = new Random();
            for (int i = 0; i < tab.Length; i++)
            {
                tab[i] = los.Next(0, 10);
            }
            Console.WriteLine(string.Join(", ", tab));

            Console.WriteLine( Max(tab) );
        }
        
        
        
        
        
        
        
        
        public static void Main1()
        {
            double z = 5.2;
            int k = 0;
            try
            {
                var u = MyPower(z, k);
                Console.WriteLine(u);
            }
            catch(ArgumentException e)
            {
                Console.WriteLine("Błędne Dane: " + e.Message);
            }
        }

        /// <summary>
        /// Podnosi liczbę x do potęgi n
        /// </summary>
        /// <param name="x">liczba zmiennoprzecinkowa, dodatnia, podstawa</param>
        /// <param name="n">liczba całkowita, nieujemna, potęga</param>
        /// <returns>liczba x podniesiona do potęgi n</returns>
        /// <remarks>Wykorzystany algorytm: n-krotne mnożenie</remarks>
        /// <exception cref="ArgumentException">x jest niedodatnie lub n jest ujemne</exception>
        static double MyPower(double x, int n)
        {
            
            if (x <= 0)
            {
                throw new ArgumentException("x nie może być ujemne");
            }
            
            if (n < 0) throw new ArgumentException("n musi być nieujemne");

            if (n == 0)
                return 1;

            double y = x;
            for (int i = 0; i < n; i++)
            {
                y *= x;
            }
                
            return y;
        }

        static int Los()
        {
            Random generator = new Random();
            return generator.Next();
        }

        static int Los1()
        {
            return (new Random()).Next();
        }

       static int Los2() => (new Random()).Next();

        static int Max(int x, int y) => (x < y) ? y : x;

        static Func<int, int, int> Min = (x, y) => (x < y) ? x : y;

        static int Max(int x, int y, int z) => Max(Max(x, y), Max(x, z));

        static int Max(int[] tab)
        {
            Debug.Assert(tab != null && tab.Length > 0);

            int max = tab[0];
            for(int i=0; i < tab.Length; i++)
            {
                if (max < tab[i]) max = tab[i];
            }
            return max;
        }
        static int Max(long x, long y)
        {
            long wynik;
            if (x < y)
                wynik = y;
            else
                wynik = x;
            return wynik;
        }

        private static void Run()
        {
            // 1.
            // 2.
        }
    }
}
