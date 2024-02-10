internal class Program
{
    private static void Main(string[] args)
    {
        int w = 10;
        int h = 10;
        int[,] macierz = new int[w, h];
        for (int i = 0; i < w; i++)
        {
            for (int j = 0; j < h; j++)
            {
                if (i == j)
                {
                    macierz[i, j] = j;
                }
                else
                {
                    macierz[i, j] = 0;
                }
            }
        }

        WypisanieTablicy(macierz);
        WyliczenieSumy(macierz);
    }
    static void WypisanieTablicy(int[,] tablica)
    {
        for (int y = 0; y < tablica.GetLength(1); y++)
        {
            for (int x = 0; x < tablica.GetLength(0); x++)
                Console.Write("{0}\t", tablica[x, y]);
            Console.WriteLine();
        }
    }

    static void WyliczenieSumy(int[,] tablica)
    {
        int suma = 0;
        for (int y = 0; y < tablica.GetLength(1); y++)
        {
            for (int x = 0; x < tablica.GetLength(0); x++)
                suma += tablica[x, y];
        }
        Console.WriteLine("Suma elementów przekątnej wynosi: {0}", suma);
    }
}