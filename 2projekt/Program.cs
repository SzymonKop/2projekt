Console.WriteLine("aplikacja do mnożenia liczby przez 10 \npodaj liczbe: ");
var tekstZKonsoli = Console.ReadLine();
var czyUdaloSiePrzekonwertowacNaLiczbe = int.TryParse(tekstZKonsoli, out int result);
if (czyUdaloSiePrzekonwertowacNaLiczbe)
{
    Console.WriteLine("wynik to:" + (result * 10));
}
else
{
    Console.WriteLine($"podany tekst [{tekstZKonsoli}] nie da się przekonwertować na liczbe");
}