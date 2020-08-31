using System;

namespace D2
{
    class Dzialania
    {
        public int wynik;

        void Dodaj(ref int a, int b)
        {
            wynik = a;
            a += b;
        }

        void Odejmij(ref int a, int b)
        {
            wynik = a;
            a -= b;
        }

        public static void Main()
        {
            Dzialania dz = new Dzialania();
            int a = 3, b = 7;
            dz.Dodaj(ref a, b);
            Console.WriteLine(a);
            dz.Odejmij(ref a, b);
            Console.WriteLine(a);
            Console.ReadKey();
        }
    }
}
