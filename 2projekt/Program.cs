internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("aplikacja do dodawania\npodaj liczbe pierwsza: ");
        var liczbaPierwsza = Console.ReadLine();
        Console.WriteLine("podaj liczbe druga");
        var liczbaDruga = Console.ReadLine();

        var czyUdaloSiePrzekonwertowac1NaLiczbe = int.TryParse(liczbaPierwsza, out int liczbaPierwszaPoKonwersji);
        var czyUdaloSiePrzekonwertowac2NaLiczbe = int.TryParse(liczbaPierwsza, out int liczbaDrugaPoKonwersji);
        if (czyUdaloSiePrzekonwertowac1NaLiczbe && czyUdaloSiePrzekonwertowac2NaLiczbe)
        {
            var wynik = Calculator.Add(liczbaPierwszaPoKonwersji, liczbaDrugaPoKonwersji);
            Console.WriteLine("wynik to:" + wynik);
        }
        else
        {
            Console.WriteLine($"jeden z podanych argumentów nie był liczbą");
        }
    }
}

public static class Calculator
{

    public static int Add(int x, int y)
    {
        return x + y;
    }
}