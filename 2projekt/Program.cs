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
                var liczby = new List<int>();
                foreach (var item in lista)
                {
                    int.TryParse(item, out var liczba);
                    liczby.Add(liczba);
                }
                var wynik = 0;
                foreach (var item in liczby)
                {
                    wynik = wynik + item;
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