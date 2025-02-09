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
                Console.WriteLine("podaj rownanie ktorego chcesz znac wynik:");
                var input = Console.ReadLine();
                var lista = input.Split("+").ToList();

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

                Console.WriteLine($"wynik to: {wynik}");
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