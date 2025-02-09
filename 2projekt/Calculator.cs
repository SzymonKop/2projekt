using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2projekt
{
    public static class Calculator

    {
        public static Int64 Multiply(Int64 x, Int64 y)
        {
            return x * y;
        }
        public static Int64 Divide(Int64 x, Int64 y)
        {
            return x / y;
        }
        public static Int64 Minus(Int64 x, Int64 y)
        {
            return x - y;
        }
        public static Int64 Add(Int64 x, Int64 y)
        {
            return x + y;
        }

        public static Int64 Process(string query)
        {
            var lista = query.Split("+").ToList();

            var iloscLiczbDodatnich = lista.Count();
            var liczby = new List<Int64>();

            foreach (var item in lista.ToList())
            {
                if (item.Length > 1)
                {
                    lista.Remove(item);
                    lista.AddRange(item.Split("-"));
                }
            }
            Int64 wynik = 0;
            foreach (var item in lista)
            {
                Int64.TryParse(item, out var liczba);
                liczby.Add(liczba);
            }

            for (int i = 0; i < liczby.Count(); i++)
            {

                if (i < iloscLiczbDodatnich)
                {
                    wynik = Calculator.Add(wynik, liczby[i]);
                }
                else
                {
                    wynik = Calculator.Minus(wynik, liczby[i]);
                }
            }
            return wynik;
        }
    }
}
