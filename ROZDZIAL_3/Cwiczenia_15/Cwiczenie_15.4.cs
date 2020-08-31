using System;

namespace D1
{
    class Dzialania
    {
        public int wynik;

        void Dodaj(int a, int b)
        {
            wynik = a + b;
        }

        void Odejmij(int a, int b)
        {
            wynik = a - b;
        }

        public static void Main()
        {
            Dzialania dz = new Dzialania();
            int a = 3, b = 7;
            dz.Dodaj(a, b);
            Console.WriteLine(dz.wynik);
            dz.Odejmij(a, b);
            Console.WriteLine(dz.wynik);
        }
    }
}

