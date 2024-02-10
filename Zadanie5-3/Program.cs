internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Podaj tytuł książki: ");
        string tytulKsiazki = Console.ReadLine();

        Console.WriteLine("Podaj nazwisko autora: ");
        string nazwiskoAutora = Console.ReadLine();

        ZapiszDoPliku("library.txt", tytulKsiazki, nazwiskoAutora);

        OdczytajIZapiszNaKonsoli("library.txt");
    }

    static void ZapiszDoPliku(string nazwaPliku, string tytul, string autor)
    {
        try
        {
            using (StreamWriter sw = new StreamWriter(nazwaPliku))
            {
                sw.WriteLine($"Tytuł książki: {tytul}");
                sw.WriteLine($"Nazwisko autora: {autor}");
            }

            Console.WriteLine("Dane zostały zapisane do pliku.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Wystąpił błąd podczas zapisywania do pliku: {ex.Message}");
        }
    }

    static void OdczytajIZapiszNaKonsoli(string nazwaPliku)
    {
        try
        {
            using (StreamReader sr = new StreamReader(nazwaPliku))
            {
                string linia;
                while ((linia = sr.ReadLine()) != null)
                {
                    Console.WriteLine(linia);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Wystąpił błąd podczas odczytywania z pliku: {ex.Message}");
        }
    }
}