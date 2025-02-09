using System.Threading.Tasks.Sources;
using _2projekt;

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
                var wynik = Calculator.Process(input);

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

