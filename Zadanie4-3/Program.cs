internal class Program
{
    private static void Main(string[] args)
    {
        int[] tablica = new int[100];

        for (int i = 0; i < 100; i++)
        {
            tablica[i] = i + 1;
        }

        int sumaLiczbParzystych = 0;
        int sumaLiczbNieparzystych = 0;

        foreach (int liczba in tablica)
        {
            if (liczba % 2 == 0)
            {
                sumaLiczbParzystych += liczba;
            }
            else
            {
                sumaLiczbNieparzystych += liczba;
            }
        }

        Console.WriteLine("Suma liczb parzystych: " + sumaLiczbParzystych);
        Console.WriteLine("Suma liczb nieparzystych: " + sumaLiczbNieparzystych);
    }
}