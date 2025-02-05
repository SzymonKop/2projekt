using System.Threading.Tasks.Sources;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("aplikacja arytmetyczna");
        do
        {
            try
            {
                Console.WriteLine("\npodaj liczbe pierwsza:");
                var liczbaPierwsza = Console.ReadLine();
                Console.WriteLine("podaj operacje arytmetyczna");
                var operacjaArytmetyczna = Console.ReadLine();
                Console.WriteLine("podaj liczbe druga");
                var liczbaDruga = Console.ReadLine();

                var czyUdaloSiePrzekonwertowac1NaLiczbe = Int64.TryParse(liczbaPierwsza, out Int64 liczbaPierwszaPoKonwersji);
                var czyUdaloSiePrzekonwertowac2NaLiczbe = Int64.TryParse(liczbaDruga, out Int64 liczbaDrugaPoKonwersji);
                if (czyUdaloSiePrzekonwertowac1NaLiczbe && czyUdaloSiePrzekonwertowac2NaLiczbe)
                {
                    Int64 wynik;
                    switch (operacjaArytmetyczna)
                    {
                        case "+":
                            wynik = Calculator.Add(liczbaPierwszaPoKonwersji, liczbaDrugaPoKonwersji);
                            Console.WriteLine($"wynik to: {wynik}");
                            break;
                        case "-":
                            wynik = Calculator.Minus(liczbaPierwszaPoKonwersji, liczbaDrugaPoKonwersji);
                            Console.WriteLine("wynik to:" + wynik);
                            break;
                        case "*":
                            wynik = Calculator.Multiply(liczbaPierwszaPoKonwersji, liczbaDrugaPoKonwersji);
                            Console.WriteLine("wynik to:" + wynik);
                            break;
                        case "/":
                            wynik = Calculator.Divide(liczbaPierwszaPoKonwersji, liczbaDrugaPoKonwersji);
                            Console.WriteLine("wynik to:" + wynik);
                            break;
                        default:
                            Console.WriteLine("error - operacja arytmetyczna nie obsługiwana");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("jeden z podanych argumentów nie był liczbą");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
        while (true);
    }
}

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
}