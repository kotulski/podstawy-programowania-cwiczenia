internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Podaj pierwszy ciąg znaków: ");
        string pierwszyLancuch = Console.ReadLine();
        Console.WriteLine("Podaj drugi ciąg znaków: ");
        string drugiLancuch = Console.ReadLine();
        dodajLancuch(pierwszyLancuch, drugiLancuch);
    }

    static void dodajLancuch(string pierwszyLancuch, string drugiLancuch)
    {
        string wynik = pierwszyLancuch +  " " + drugiLancuch;
        Console.WriteLine(wynik);
    }
}