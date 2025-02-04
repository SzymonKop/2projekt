using System.Threading.Tasks.Sources;

internal class Program
{
    private static void Main(string[] args)
    {

        do
        {
            Console.WriteLine("aplikacja do dodawania\npodaj liczbe pierwsza: ");
            var liczbaPierwsza = Console.ReadLine();
            Console.WriteLine("podaj operacje arytmetyczna");
            var operacjaArytmetyczna = Console.ReadLine();
            Console.WriteLine("podaj liczbe druga");
            var liczbaDruga = Console.ReadLine();

            var czyUdaloSiePrzekonwertowac1NaLiczbe = Int64.TryParse(liczbaPierwsza, out Int64 liczbaPierwszaPoKonwersji);
            var czyUdaloSiePrzekonwertowac2NaLiczbe = Int64.TryParse(liczbaDruga, out Int64 liczbaDrugaPoKonwersji);
            if (czyUdaloSiePrzekonwertowac1NaLiczbe && czyUdaloSiePrzekonwertowac2NaLiczbe)
            {
                if (operacjaArytmetyczna == "+")
                {
                    var wynik = Calculator.Add(liczbaPierwszaPoKonwersji, liczbaDrugaPoKonwersji);
                    Console.WriteLine($"wynik to: {wynik}");
                }
                else if (operacjaArytmetyczna == "-")
                {
                    var wynik = Calculator.Minus(liczbaPierwszaPoKonwersji, liczbaDrugaPoKonwersji);
                    Console.WriteLine("wynik to:" + wynik);
                }
                else
                {
                    Console.WriteLine("error - operacja arytmetyczna nie obsługiwana");
                }
            }
            else
            {
                Console.WriteLine("jeden z podanych argumentów nie był liczbą");
            }
        }
        while (true);
    }
}

public static class Calculator
{
    public static Int64 Minus(Int64 x, Int64 y)
    {
        return x - y;
    }
    public static Int64 Add(Int64 x, Int64 y)
    {
        return x + y;
    }
}