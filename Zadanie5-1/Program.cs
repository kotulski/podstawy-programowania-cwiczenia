internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Podaj miasto: ");
        var miasto = Console.ReadLine();
        Console.WriteLine("Podaj województwo: ");
        var wojewodztwo = Console.ReadLine();
        dlugosc(miasto, wojewodztwo);
    }

    static void dlugosc(string miasto, string wojewodztwo)
    {
        Console.WriteLine($"Nazwa miasta {miasto} zawiera {miasto.Length} liter. Nazwa województwa {wojewodztwo} zawiera {miasto.Length} liter.");
    }
}
